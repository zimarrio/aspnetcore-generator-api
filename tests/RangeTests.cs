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
        [InlineData(1000)]
        public void CountShouldControlNumberOfResults(int expectedCount)
        {
            var range = new Range { Count = expectedCount };

            var generated = range.Of(() => "");

            Assert.Equal(expectedCount, generated.Count());
        }

        [Fact]
        public void SortShouldOrderResults()
        {
            var range = new Range {Count = 3, Sort = true } ;
            var values = new[] {"a", "c", "b"};
            var counter = 0;
            var generated = range.Of(() => values[counter++]);

            Assert.Equal(new[] {"a", "b", "c"}, generated.ToArray());
        }
    }
}
