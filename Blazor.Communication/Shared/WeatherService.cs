using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Blazor.Communication.Shared
{
    public class WeatherService : IWeatherService
    {
        public async ValueTask<IEnumerable<WeatherForecast>> GetForecasts()
        {
            //var forecasts = await httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
            // return forecasts;
            throw new NotImplementedException();
        }
    }
}
