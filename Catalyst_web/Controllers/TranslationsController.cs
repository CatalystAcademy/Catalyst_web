using Microsoft.AspNetCore.Mvc;
using Catalyst_web.Interfaces;
using Catalyst_web.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace Catalyst_web.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [ApiController]
    public class TranslationsController(ILocService locService) : ControllerBase
    {
        private readonly ILocService _locService = locService;

        [HttpGet("api/Translations")]
        public IActionResult GetTranslations(string languageCode)
        {
            var translations = _locService.GetAllTranslations(languageCode);
            return Ok(translations);
        }
    }
}
