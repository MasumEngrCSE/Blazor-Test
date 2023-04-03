using Fluxor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using UsingRedux.Client;
using UsingRedux.Shared.Stores;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

Assembly storeAssembly = typeof(AppStore).Assembly;
builder.Services
.AddFluxor(options =>
options.ScanAssemblies(storeAssembly));

await builder.Build().RunAsync();
