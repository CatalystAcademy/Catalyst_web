using Auth0.AspNetCore.Authentication;
using Catalyst_web.Configuration;
using Catalyst_web.Configuration.Extensions;
using Catalyst_web.Infrastructure.Persistence;
using Catalyst_web.Infrastructure.Services;
using Catalyst_web.Interfaces;
using Catalyst_web.Models;
using Catalyst_web.validator;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
/*builder.Services.AddScoped<IValidator<Visit>, VisitValidator>();
*/
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

builder.Services.AddAuth0WebAppAuthentication(options =>
{
    options.Domain = "dev-qlacipwr2qzedmrm.us.auth0.com";
    options.ClientId = "lwBSsI8GiQzuthq5jRofL8XRtqZOIguK";
});

builder.Services.RegisterServices(configuration);

var app = builder.Build();

// Use CORS middleware
app.UseCors("AllowSpecificOrigin");


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();
}

var locOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
if (locOptions != null) app.UseRequestLocalization(locOptions.Value);

app.UseForwardedHeaders();
app.UseCultureMiddleware();
app.UseAuthentication();
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
