using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingRedux.Shared.Stores
{
    // AppStore is an immutable reference type!
    public record AppStore
    (
        int ClickCounter,
        bool IsLoading,
        WeatherForecast[]? Forecasts
        );

}
