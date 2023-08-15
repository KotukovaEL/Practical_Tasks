using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Methods.Tests
{
    public class GetDistance_2Tests
    {
        [Fact]
        public void Should_get_distance_2_correctly()
        {
            var expected = 2.8284271247461903;
            var a = 1;
            var b = 2;
            var c = 3;
            var d = 4;
            var result = Class1.GetDistance_2(a, b, c, d);
            Assert.Equal(expected, result);
        }
    }
}
