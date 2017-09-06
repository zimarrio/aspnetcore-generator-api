using System;
using System.Linq;
using api.Controllers;
using Xunit;

namespace tests
{
    public class RangeTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(100)]
        public void CountShouldControlNumberOfResults(int expectedCount)
        {
            var range = new Range { Count = expectedCount };

            var generated = range.Of(() => "");

            Assert.Equal(expectedCount, generated.Count());
        }
    }
}
