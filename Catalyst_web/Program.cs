using Catalyst_web.Configuration.Extensions;
using Catalyst_web.Infrastructure.Persistence;
using Catalyst_web.Infrastructure.Services;
using Catalyst_web.Interfaces;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterServices(configuration);
// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("http://localhost:3000")
                           .AllowAnyMethod()
                           .AllowAnyHeader());
});



/*builder.Services.AddLocalization(opts => opts.ResourcesPath = "Resources");
builder.Services.Configure<RequestLocalizationOptions>(options =>
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
builder.Services.AddTransient<ILocService, LocService>();*/

builder.Services.RegisterServices(configuration);

var app = builder.Build();

// Use CORS middleware
app.UseCors("AllowSpecificOrigin");


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var locOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
if (locOptions != null) app.UseRequestLocalization(locOptions.Value);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var logger = app.Services.GetService<ILogger<Program>>();
    try
    {
        var context = services.GetService<ApplicationDbContext>();
        if (context.Database.IsNpgsql())
        {
            await context?.Database.MigrateAsync();
        }
    }
    catch (Exception ex)
    {
        logger?.LogError(ex, "An error occurred while migrating or initializing the database");
        throw;
    }
}

app.Run();
