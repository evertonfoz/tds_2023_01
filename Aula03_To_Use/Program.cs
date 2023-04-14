using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();


Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();
builder.Host.UseSerilog(Log.Logger);

var app = builder.Build();

app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("pt-BR"),
    SupportedCultures = new[] { new CultureInfo("pt-BR") },
    SupportedUICultures = new[] { new CultureInfo("pt-BR") },
    RequestCultureProviders = new List<IRequestCultureProvider>
    {
        new CustomRequestCultureProvider(async context =>
        {
            return await Task.FromResult(new ProviderCultureResult("pt-BR"));
        })
    }
});

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();



//app.MapGet("/", () => "Hello World!");

app.Run();
