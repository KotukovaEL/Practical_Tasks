using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Methods.Tests
{
    public class FindMin_for_Task2_6_1_2Tests
    {
        [Fact]
        public void Should_find_min_between_numbers_for_Task2_6_1_2_correctly()
        {
            var expected = 1;
            var a = 1;
            var b = 2;
            var c = 4;
            var d = 5;
            var result = Logic.FindMin_for_Task_2_6_1_2(a, b, c, d);
            Assert.Equal(expected, result);
        }
    }
}
