using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Shared;
using Xunit;

namespace Testing.ComponentTests
{
    public class SquareShould
    {
        [Fact]
        public void Return9For3()
        {

            // Arrange
            var sut = new Utils();
            // Act
            var actual = sut.Square(3);
            // Assert
            Assert.Equal(expected: 9, actual: actual);

        }
    }
}
