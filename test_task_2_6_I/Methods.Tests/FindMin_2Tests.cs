using System;
using System.Collections.Generic;
using Xunit;
using Methods;

namespace Methods.Tests
{
    public class FindMin_2Tests
    {
        [Fact]
        public void Should_find_min_between_numbers_1_correctly()
        {
            var expected = 2;
            var a = 1;
            var b = 2;
            var result = Class1.FindMin_2(a, b);
            Assert.Equal(expected, result);
        }
    }
}
