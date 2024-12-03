using Microsoft.EntityFrameworkCore;
using NhienDentistry.Core.Common;
using NhienDentistry.DataBase.EF;
using NhienDentistry.DataBase.Entities;
using NhienDentistry.ViewModels.Catalog.Articles;
using NhienDentistry.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NhienDentistry.Core.Catalog.Articles
{
    internal class ArticlesService : IArticlesService
    {
        private readonly NhienDbContext _context;
        private readonly IStorageService _fileStorageService;
        public ArticlesService(NhienDbContext dbContext, IStorageService storage) {
            _context = dbContext;        
            _fileStorageService = storage;
        }

        public async Task<ArticleVm> Create(ArticleRequestCreated request)
        {
            var art = new Article()
            {
                LanguageId  = 1,
                Name = request.Name,
                Alias = request.Alias,
                SortOrder = request.SortOrder,
                Description = request.Description,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                showHome = request.showHome,
                Images = []
            };
            if (request.ThumbnailImages.Count > 0)
            {
                foreach (var file in request.ThumbnailImages)
                {
                    if (file != null) {
                        var _image = new Image()
                        {
                            FileSize = file.Length,
                            CreatedDate = DateTime.Now,
                            Path = await _fileStorageService.SaveFileAsync(file),
                            Type = file.ContentType,
                                
                        };
                        art.Images.Add(_image);
                    }
                };
            }
            _context.Articles.Add(art);
            await _context.SaveChangesAsync();

            return new ArticleVm()
            {
                Alias = art.Alias,
                CreatedDate = art.CreatedDate,
                Description = art.Description,   
                Id = art.Id,
                Name = art.Name,
                showHome = art.showHome,
                SortOrder = art.SortOrder,
                UpdatedDate = art.UpdatedDate,
            };
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var article = _context.Articles.FirstOrDefault(a => a.Id == id);
                if (article != null)
                {
                    if (article.Images.Count > 0)
                    {
                        _context.Images.RemoveRange(article.Images);
                    }
                    article.Status = Date.Enums.Status.InActive;
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) {
                return false;   
            }
        }

        public async Task<PagedResult<ArticleVm>> GetAllPaging(GetManageArticlePagingRequest request)
        {
            var query = _context.Articles;
            if (query != null && !string.IsNullOrEmpty(request.Keyword))
            {
                query = (DbSet<Article>)query.Where(x => x.Name.Contains(request.Keyword, StringComparison.CurrentCultureIgnoreCase));
            }
            if (query != null && request.LanguageId != null)
            {
                query = (DbSet<Article>?)query.Where(x => x.LanguageId == request.LanguageId);
            }
            if (query != null && request.CategoryId != null)
            {
                query = (DbSet<Article>?)query.Where(x => x.CategoryId == request.CategoryId);
            }
            var total = query.Count();
            query = (DbSet<Article>)query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize);
            var articles = await query.Select(x => new ArticleVm() {
                Name = x.Name,
                Alias = x.Alias,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                showHome = x.showHome,
                Id = x.Id,
                UpdatedDate = x.UpdatedDate
            }).ToListAsync();
            //4. Select and projection
            var pagedResult = new PagedResult<ArticleVm>()
            {
                TotalRecords = total,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = articles
            };
            return pagedResult;

        }

        public async Task<ArticleVm> GetById(int id)
        {
            var query = await _context.Articles.Where(x => x.Id == id).ToListAsync();
            var article = new ArticleVm();
            if (query != null)
            {
                article = query.Select(x => new ArticleVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Alias = x.Alias,
                    CreatedDate = x.CreatedDate,
                    Description = x.Description,
                    showHome = x.showHome,
                    SortOrder = x.SortOrder,
                    UpdatedDate = x.UpdatedDate
                }).FirstOrDefault();
            }
            return article!;
        }

        public Task<ArticleVm> Update(ArticleRequestUpdated request)
        {
            throw new NotImplementedException();
        }
    }
}
