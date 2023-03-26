using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Communication.Shared
{
    public interface IWeatherServiceFactory
    {
        IWeatherService Create();
    }
}
