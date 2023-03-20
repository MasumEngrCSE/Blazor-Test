using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Shared;

namespace Testing.ComponentTests
{
    public class WeatherServiceStub : IWeatherService
    {
        public IEnumerable<WeatherForecast> FakeForecasts { get; set; }
        = default!;
        public ValueTask<IEnumerable<WeatherForecast>> GetForecasts()
        => new ValueTask<IEnumerable<WeatherForecast>>(
        FakeForecasts);
    }
}
