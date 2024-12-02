using NhienDentistry.DataBase.EF;
using NhienDentistry.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NhienDentistry.Core.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly NhienDbContext _context;

        public CategoryService(NhienDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryVm>> GetAll(int languageId)
        {
            var query = await _context.Categories.Where(x => x.CategoryTranslations.FirstOrDefault(x => x.LanguageId == languageId) != null).ToListAsync();
            return query.Select(x => new CategoryVm()
            {
                Id = x.Id,
                Name = x.Name,
                ParentId = x.ParentId
            }).ToList();
        }

        public async Task<CategoryVm> GetById(int languageId, int id)
        {
            var query = await _context.Categories.Where(x => x.CategoryTranslations.FirstOrDefault(x => x.LanguageId == languageId) != null).ToListAsync();
            return query.Select(x => new CategoryVm()
            {
                Id = x.Id,
                Name = x.Name,
                ParentId = x.ParentId
            }).FirstOrDefault();
        }
    }
}