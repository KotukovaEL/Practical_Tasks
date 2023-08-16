using Xunit;

namespace Methods.Tests
{
    public class EnsureTriangleTests
    {
        [Theory]
        [InlineData(1, 2, 3, "Треугольник не существует")]
        [InlineData(8, 2, 5, "Треугольник не существует")]
        public void Should_ensure_triangle_correctly(int a, int b, int c, string expectedValue)
        {
            var result = Logic.EnsureTriangle(a, b, c);
            Assert.Equal(expectedValue, result);
        }
    }
}
