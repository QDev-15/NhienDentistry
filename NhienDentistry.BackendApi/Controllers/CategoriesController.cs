using Microsoft.AspNetCore.Mvc;
using NhienDentistry.Core.Catalog.Categories;

namespace NhienDentistry.BackendApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(
            ICategoryService categoryService
        ) {
            _categoryService = categoryService;
        }
        [HttpGet("{id}")]  // default language id = 1: VN
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetById(1, id);
            return Ok(category);
        }
        [HttpGet("{langId}/{id}")]
        public async Task<IActionResult> GetById(int langId, int id)
        {
            var category = await _categoryService.GetById(langId, id);
            return Ok(category);
        }
        [HttpGet()] // default language id = 1: VN
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAll(1);
            return Ok(categories);
        }
        [HttpGet("{langId}")] // default language id = 1: VN
        public async Task<IActionResult> GetAll(int langId)
        {
            var categories = await _categoryService.GetAll(langId);
            return Ok(categories);
        }
    }
}
