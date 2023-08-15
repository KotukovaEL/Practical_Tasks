using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Methods.Tests
{
    public class EnsureTriangle_1Tests
    {
        [Fact]
        public void Should_ensure_triangle_1_correctly()
        {
            var expected = "Треугольник не существует";
            var a = 1;
            var b = 2;
            var c = 3;
            var result = Class1.EnsureTriangle_1(a, b, c);
            Assert.Equal(expected, result);
        }
    }
}
