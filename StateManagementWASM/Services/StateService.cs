using System.Net.Http.Json;

namespace StateManagementWASM.Services
{
    public class StateService<T>
    {
        private readonly HttpClient httpClient;
        public StateService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<int?> GetState(string user)=> await httpClient.GetFromJsonAsync<int>($"state/{user}");
        public async Task SetState(string user, T state)=> await httpClient.PostAsJsonAsync($"state/{user}", state);
    }
}
