﻿using Bunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Client.Pages;

namespace Testing.ComponentTests
{
    public class TwoWayCounterShould : TestContext
    {
        [Fact]
        public void IncrementCounterWhenClicked()
        {
            var cut = RenderComponent<TwoWayCounter>(
            parameters =>
            parameters.Add(counter => counter.CurrentCount, 0)
            .Add(counter => counter.Increment, 1)
            );
            cut.Find("button").Click();
            cut.Find("p")
            .MarkupMatches("<p>Current count: 1</p>");
        }



        [Theory]
        [InlineData(3)]
        [InlineData(-3)]
        public void IncrementCounterWithIncrementWhenClicked(int increment)
        {
            var cut = RenderComponent<TwoWayCounter>(
            ("CurrentCount", 0),
            ("Increment", increment)
            );
            cut.Find("button").Click();
            cut.Find("p")
            .MarkupMatches($"<p>Current count: {increment}</p>");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(-3)]
        public void IncrementCounterWithIncrementWhenClickedWithNameOf(int increment)
        {
            var cut = RenderComponent<TwoWayCounter>(
            (nameof(TwoWayCounter.CurrentCount), 0),
            (nameof(TwoWayCounter.Increment), increment)
            );
            cut.Find("button").Click();
            cut.Find("p")
            .MarkupMatches($"<p>Current count: {increment}</p>");
        }




    }
}