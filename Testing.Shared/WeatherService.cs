﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Shared
{
    public class WeatherService : IWeatherService
    {
        public ValueTask<IEnumerable<WeatherForecast>> GetForecasts()
        {
            throw new NotImplementedException();
        }
    }
}
