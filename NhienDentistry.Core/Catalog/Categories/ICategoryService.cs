using Nhientistry.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NhienDentistry.Core.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll(int languageId);

        Task<CategoryVm> GetById(int languageId, int id);
    }
}