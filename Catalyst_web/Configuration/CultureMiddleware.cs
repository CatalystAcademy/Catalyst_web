using Microsoft.AspNetCore.Localization;
using System.Globalization;

namespace Catalyst_web.Configuration
{
    public class CultureMiddleware
    {
        private readonly RequestDelegate _next;

        public CultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Get culture from request headers
            var culture = context.Request.Cookies["i18n_redirected"];

            if (!string.IsNullOrWhiteSpace(culture))
            {
                // Set the culture
                CultureInfo.CurrentCulture = new CultureInfo(culture);
                CultureInfo.CurrentUICulture = new CultureInfo(culture);
            }

            // Call the next delegate/middleware in the pipeline
            await _next(context);
        }
    }

    public static class CultureMiddlewareExtensions
    {
        public static IApplicationBuilder UseCultureMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CultureMiddleware>();
        }
    }
}
