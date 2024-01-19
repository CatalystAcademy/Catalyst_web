using System.Globalization;
using System.Reflection;
using Catalyst_web.Infrastructure.Persistence;
using Catalyst_web.Infrastructure.Services;
using Catalyst_web.Interfaces;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;

namespace Catalyst_web.Configuration.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection RegisterServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddHttpContextAccessor();
        // Configure database
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.EnableSensitiveDataLogging();
            options.UseNpgsql(configuration.GetConnectionString("db"));
        });
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
        
        // Configure localization
        services.AddLocalization(opts => opts.ResourcesPath = "Resources");
        services.Configure<RequestLocalizationOptions>(options =>
        {
            var supportedCultures = new List<CultureInfo>
            {
                new("en-US"),
                new("hy-AM")
            };
            supportedCultures[1].NumberFormat.NumberDecimalSeparator = ".";
            supportedCultures[1].DateTimeFormat.DateSeparator = "yyyy-MM-dd";
            options.DefaultRequestCulture = new RequestCulture("en-US");
            options.SupportedCultures = supportedCultures;
            options.SupportedUICultures = supportedCultures;
            options.RequestCultureProviders = new List<IRequestCultureProvider>
            {
                new CookieRequestCultureProvider()
            };
        });
        services.AddTransient<ILocService, LocService>();
        
        // Configure MediatR
        services.AddMediatR(serviceConfiguration =>
        {
            serviceConfiguration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
        
        return services;
    }
}