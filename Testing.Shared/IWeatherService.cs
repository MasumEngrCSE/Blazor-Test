using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Shared
{
    public interface IWeatherService
    {
        //ValueTask<IEnumerable<WeatherForecast>> GetForecasts();
        ValueTask<IEnumerable<WeatherForecast>> GetForecasts();
    }
}
