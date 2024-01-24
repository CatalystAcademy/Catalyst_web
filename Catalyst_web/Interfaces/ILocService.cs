using Microsoft.Extensions.Localization;

namespace Catalyst_web.Interfaces;

public interface ILocService
{
    LocalizedString Get(string key);     
    string? Get(string key, string cultureName );
    IDictionary<string, string> GetAllTranslations(string cultureName);
}