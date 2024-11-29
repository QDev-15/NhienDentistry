using NhienDentistry.Core.Common;
using NhienDentistry.DataBase.EF;
using NhienDentistry.DataBase.Entities;
using NhienDentistry.ViewModels.Catalog.Articles;
using NhienDentistry.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Task<bool> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<ArticleVm>> GetAllPaging(GetManageArticlePagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ArticleVm> GetById(int productId, string languageId)
        {
            throw new NotImplementedException();
        }

        public Task<ArticleVm> Update(ArticleRequestUpdated request)
        {
            throw new NotImplementedException();
        }
    }
}
