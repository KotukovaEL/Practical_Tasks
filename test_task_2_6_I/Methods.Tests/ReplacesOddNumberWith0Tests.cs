using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Methods.Tests
{
    public class ReplacesOddNumberWith0Tests
    {
        [Fact]
        public void Should_replaces_odd_number_with_0_correctly()
        {
            var expected = 0;
            var x = 1;
            var result = Class1.ReplacesOddNumberWith0(x);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_replaces_even_number_decreases_in_2_correctly()
        {
            var expected = 1;
            var x = 2;
            var result = Class1.ReplacesOddNumberWith0(x);
            Assert.Equal(expected, result);
        }
    }
}
