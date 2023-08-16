using System;
using System.Collections.Generic;
using Xunit;
using Methods;

namespace Methods.Tests
{
    public class FindMin_for_Task2_6_1_1Tests
    {
        [Fact]
        public void Should_find_min_between_numbers_for_Task2_6_1_1_correctly()
        {
            var expected = 2;
            var a = 1;
            var b = 2;
            var result = Logic.FindMin_for_Task2_6_1_1(a, b);
            Assert.Equal(expected, result);
        }
    }
}
