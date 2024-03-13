using System.Globalization;
using System.Reflection;
using Catalyst_web.Infrastructure.Persistence;
using Catalyst_web.Infrastructure.Services;
using Catalyst_web.Interfaces;
using Catalyst_web.Models;
using Catalyst_web.validator;
using FluentValidation;
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

        services.Configure<CookiePolicyOptions>(options =>
        {
            // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            options.CheckConsentNeeded = context => true;
            options.MinimumSameSitePolicy = SameSiteMode.Unspecified;
/*            options.OnAppendCookie = cookieContext =>
                CookieSameSiteChecker.CheckSameSite(cookieContext.Context, cookieContext.CookieOptions);
            options.OnDeleteCookie = cookieContext =>
                CookieSameSiteChecker.CheckSameSite(cookieContext.Context, cookieContext.CookieOptions);*/
        });


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
        /*        services.AddMediatR(serviceConfiguration =>
                {
                    serviceConfiguration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                });*/

        return services;
    }
}