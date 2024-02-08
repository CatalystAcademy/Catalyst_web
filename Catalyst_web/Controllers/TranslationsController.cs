using Microsoft.AspNetCore.Mvc;
using Catalyst_web.Interfaces;
using Catalyst_web.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Localization;

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

        [HttpGet("api/SetLanguage")]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1), IsEssential = true }
            );
            return LocalRedirect(returnUrl);
        }
    }
}
