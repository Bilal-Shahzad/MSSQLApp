using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MSSQLApp.Data;

var builder = WebApplication.CreateBuilder(args);
// Creates a WebApplication builder with default configurations.

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<AppDbContext>();
// Adds services to the DI container:
// - Razor Pages and Server-Side Blazor for the UI.
// - Singleton `WeatherForecastService` (shared across all requests).
// - Scoped `AppDbContext` (a new instance per request).


var app = builder.Build();
// Builds the application with the configured services.

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
// Ensures secure requests and serves static files.

app.UseRouting(); // Sets up endpoint routing for the app.

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
// Maps Blazor Server Hub and specifies fallback routing to `_Host`.

app.Run();
// Runs the app.
