using L10nBlazorServer.Data;
using L10nBlazorServer.Globalization;
//using L10nBlazorServer.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.AddLocalization();
builder.Services.AddControllersWithViews()
    .AddViewLocalization
    (LanguageViewLocationExpanderFormat.SubFolder)
    .AddDataAnnotationsLocalization();

builder.Services.Configure<RequestLocalizationOptions>(options => {

    //Dictionary<string, string> cultures =Configuration.GetCulturesSection();
    Dictionary<string, string> cultures = builder.Configuration.GetCulturesSection();
    string[] supportedCultures =cultures.Keys.ToArray();

    //var supportedCultures = new[] { "en-US", "fr", "de" };



options.SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);
});

Dictionary<string, string> cultures = builder.Configuration.GetCulturesSection();
string[] supportedCultures = cultures.Keys.ToArray();

var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

localizationOptions.RequestCultureProviders.Clear();
localizationOptions.RequestCultureProviders.Add(new AcceptLanguageHeaderRequestCultureProvider());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRequestLocalization(localizationOptions);
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
