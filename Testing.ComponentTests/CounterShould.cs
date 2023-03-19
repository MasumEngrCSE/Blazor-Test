using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunit;
using Testing.Client.Pages;
using Xunit;

namespace Testing.ComponentTests
{
    public class CounterShould : TestContext
    {
        [Fact]
        public void RenderCorrectlyWithInitialZero()
        {
            //var cut = RenderComponent<Counter>();
            var cut = RenderComponent<Counter>();



            cut.Find(cssSelector: "button")
                .Click();
            cut.Find(cssSelector: "p")
            .MarkupMatches(@"<p>Current count: 1</p>");

            //cut
            //   .Find(cssSelector: "p")
            //   .MarkupMatches("<p>Current count: 0</p>");


            //cut.MarkupMatches(@"
            //                    <h1>Counter</h1>
            //                    <p>Current count: 0</p>
            //                    <button class=""btn btn-primary"" >
            //                    Click me
            //                    </button>
            //                    ");


            //Assert.Equal(@"
            //        <h1>Counter</h1>
            //        <p>Current count: 0</p>
            //        <button class=""btn btn-primary"" >
            //        Click me
            //        </button>
            //        ", cut.Markup);
        }
    }
}
