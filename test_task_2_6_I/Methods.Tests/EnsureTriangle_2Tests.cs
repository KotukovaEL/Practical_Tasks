using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Methods.Tests
{
    public class EnsureTriangle_2Tests
    {
        [Fact]
        public void Should_ensure_triangle_2_correctly()
        {
            var expected = false;
            var a = 1;
            var b = 2;
            var c = 3;
            var result = Class1.EnsureTriangle_2(a, b, c);
            Assert.Equal(expected, result);
        }
    }
}
