using Blazor.Communication.Shared;

namespace Blazor.Communication.Client.Services
{
    public class WeatherServiceFactory : IWeatherServiceFactory
    {
        private readonly HttpClient httpClient;
        public WeatherServiceFactory(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        //Pages:377
        //public IWeatherService Create() => new WeatherService(httpClient);
        public IWeatherService Create() => new WeatherService();
    }
}
