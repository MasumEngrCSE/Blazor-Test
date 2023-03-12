//using Microsoft.AspNetCore.Components.Web;
//using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
//using PizzaPlace;
//using PizzaPlace.Client.Services;
//using PizzaPlace.Client.Shared;

using PizzaPlace.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PizzaPlace;
using PizzaPlace.Client.Shared;
using PizzaPlace.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddTransient<IMenuService, MenuService>();
//builder.Services.AddTransient<IMenuService, HardCodedMenuService>();

builder.Services.AddTransient<IOrderService, ConsoleOrderService>();


await builder.Build().RunAsync();


//namespace PizzaPlace.Client
//{
//    public class Program
//    {
//        public static async Task Main(string[] args)
//        {
//            var builder = WebAssemblyHostBuilder.CreateDefault(args);
//            builder.RootComponents.Add<App>("#app");
//            builder.Services.AddScoped(sp => new HttpClient
//            {
//                BaseAddress = new Uri(
//            builder.HostEnvironment.BaseAddress)
//            });


//            builder.Services.AddTransient<IMenuService, MenuService>();
//            //builder.Services.AddTransient<IMenuService, HardCodedMenuService>();

//            builder.Services.AddTransient<IOrderService, ConsoleOrderService>();


//            await builder.Build().RunAsync();
//        }
//    }
//}