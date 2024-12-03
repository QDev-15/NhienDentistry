using NhienDentistry.ViewModels.Catalog.Categories;

namespace NhienDentistry.Core.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll(int languageId);

        Task<CategoryVm> GetById(int languageId, int id);
    }
}