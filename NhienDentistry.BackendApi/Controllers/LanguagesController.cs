using Microsoft.AspNetCore.Mvc;
using NhienDentistry.Core.System.Languages;

namespace NhienDentistry.BackendApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguageService _languageService;

        public LanguagesController(
            ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var products = await _languageService.GetAll();
            return Ok(products);
        }
    }
}
