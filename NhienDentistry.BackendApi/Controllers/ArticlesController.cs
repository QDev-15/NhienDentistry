using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NhienDentistry.Core.Catalog.Articles;
using NhienDentistry.ViewModels.Catalog.Articles;

namespace NhienDentistry.BackendApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [Authorize]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticlesService _articlesService;
        public ArticlesController(IArticlesService articlesService) {
            _articlesService = articlesService;        
        }

        [HttpGet("paging")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetManageArticlePagingRequest request)
        {
            var articles = await _articlesService.GetAllPaging(request);
            return Ok(articles);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var article = await _articlesService.GetById(id);
            return Ok(article);
        }
    }
}
