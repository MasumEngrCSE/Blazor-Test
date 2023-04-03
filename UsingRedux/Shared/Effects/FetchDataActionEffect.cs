using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using UsingRedux.Shared.Actions;

namespace UsingRedux.Shared.Effects
{
    public class FetchDataActionEffect : Effect<FetchDataAction>
    {
        private readonly HttpClient httpClient;
        public FetchDataActionEffect(HttpClient http)=> this.httpClient = http;
        public override async Task HandleAsync(FetchDataAction action, IDispatcher dispatcher)
        {
            try
            {
                WeatherForecast[]? forecasts = await this.httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
                dispatcher.Dispatch(new FetchDataResultAction(forecasts));
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
