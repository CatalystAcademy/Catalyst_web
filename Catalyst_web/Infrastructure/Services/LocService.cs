using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Catalyst_web.Interfaces;
using Catalyst_web.Resources;
using Microsoft.Extensions.Localization;

namespace Catalyst_web.Infrastructure.Services;

public class LocService : ILocService
{
    private readonly IStringLocalizer _localizer;
    private readonly IStringLocalizerFactory _localizerFactory;

    public LocService(IStringLocalizerFactory localizerFactory)
    {
        _localizerFactory = localizerFactory;
        var type = typeof(SharedResource);
        var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
        _localizer = _localizerFactory.Create("SharedResource", assemblyName.Name);
    }

    public LocalizedString Get(string key)
    {
        return _localizer[key];
    }
        
    public string? Get(string key, string cultureName)
    {
        return SharedResource.ResourceManager.GetString(key, CultureInfo.GetCultureInfo(cultureName));
    }

    public IDictionary<string, string> GetAllTranslations(string cultureName)
    {
        var culture = CultureInfo.GetCultureInfo(cultureName);

        var resourceManager = new ResourceManager("Catalyst_web.Resources.SharedResource", Assembly.GetExecutingAssembly());

        var resourceSet = resourceManager.GetResourceSet(culture, true, false);
        var translations = new Dictionary<string, string>();

        foreach (DictionaryEntry entry in resourceSet)
        {
            translations[(string)entry.Key] = (string)entry.Value;
        }

        return translations;
    }

}

