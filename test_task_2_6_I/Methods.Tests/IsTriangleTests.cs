using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Methods.Tests
{
    public class IsTriangleTests
    {
        [Theory]
        [InlineData(1,2,3, false)]
        [InlineData(7, 4, 9, true)]
        public void Should_exist_triangle_or_not_correctly(int a, int b, int c, bool expectedValue)
        {
            var result = Logic.ISTriangle(a, b, c);
            Assert.Equal(result, expectedValue);
        }
    }
}
