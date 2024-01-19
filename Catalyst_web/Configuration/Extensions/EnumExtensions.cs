using Catalyst_web.Interfaces;
using Catalyst_web.Infrastructure.Services;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Catalyst_web.Configuration.Extensions
{
    public static class EnumExtensions
    {
        public static IHtmlContent EnumToString<T>(this IHtmlHelper helper)
        {
            var values = Enum.GetValues(typeof(T)).Cast<int>();
            var enumDictionary = values.ToDictionary(value => Enum.GetName(typeof(T), value));
            return helper.Raw(JsonConvert.SerializeObject(enumDictionary));
        }
        
        public static string Localized<TEnum>(this TEnum model) where TEnum : struct
        {
            using var serviceScope = ServiceActivator.GetScope();
            var locService = serviceScope.ServiceProvider.GetService<ILocService>();
            return locService.Get(model.ToString());
        }
    }
}
