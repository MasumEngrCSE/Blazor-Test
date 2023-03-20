using Bunit;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Shared;
using Testing.Client.Pages;
using Xunit;

namespace Testing.ComponentTests
{
    public class FetchDataShould : TestContext
    {



        [Fact]
        public void UseWeatherService()
        {
            const int nrOfForecasts = 5;
            var stub = new WeatherServiceStub
            {
                FakeForecasts = Enumerable.Repeat(new WeatherForecast(),
            nrOfForecasts)
            };
            Services.AddSingleton<IWeatherService>(stub);
            var cut = RenderComponent<FetchData>();
            var rows = cut.FindAll("tbody tr");
            rows.Count.Should().Be(nrOfForecasts);
        }


        //[Fact]
        //public void UseWeatherService()
        //{
        //    // Use Services for dependency injection
        //    Services.AddSingleton<IWeatherService,
        //    Testing.Shared.WeatherService>();
        //    var cut = RenderComponent<FetchData>();
        //    var rows = cut.FindAll("tbody tr");
        //    rows.Count.Should().Be(5);
        //}
    }
}
