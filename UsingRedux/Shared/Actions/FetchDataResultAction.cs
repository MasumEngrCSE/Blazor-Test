using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingRedux.Shared.Actions
{
    public record FetchDataResultAction(WeatherForecast[]? Forecasts);
}
