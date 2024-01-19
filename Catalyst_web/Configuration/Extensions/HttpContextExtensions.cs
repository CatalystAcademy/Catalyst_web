using Microsoft.AspNetCore.Localization;

namespace Catalyst_web.Configuration.Extensions
{
    public static class HttpContextExtensions
    {
        public static bool IsUiCultureEnglish(this HttpContext context)
        {
            return context.GetCurrentUiCulture() == "en-US";
        }

        public static bool IsUiCultureArmenian(this HttpContext context)
        {
            return context.GetCurrentUiCulture() == "hy-AM";
        }
        
        public static bool IsUiCultureRussian(this HttpContext context)
        {
            return context.GetCurrentUiCulture() == "ru-RU";
        }

        public static string GetCurrentUiCulture(this HttpContext context)
        {
            return context.Features.Get<IRequestCultureFeature>().RequestCulture.UICulture.Name;
        }
    }
}