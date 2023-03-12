using PizzaPlace.Client.Shared;
using System.Net.Http.Json;

namespace PizzaPlace.Client.Services
{
    public class MenuService : IMenuService
    {
        private readonly HttpClient httpClient;
        public MenuService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async ValueTask<Menu> GetMenu()
        {
            var pizzas = await httpClient.GetFromJsonAsync<Pizza[]>("/pizzas");

            return new Menu { Pizzas = pizzas!.ToList() };
            //throw new NotImplementedException();
        }
    }
}
