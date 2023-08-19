using FluentAssertions;
using Xunit;

namespace CommonArray.Tests
{
    public class FindMaxTests
    {
        [Fact]
        public void Should_find_max_correctly_when_one_number()
        {
            var expectedArray = 77;
            var array = new[] { 55, -20, 60, 8, 77 };
            var actualArray = ArrayHelpers.FindMax(array);
            actualArray.Equals(expectedArray);
        }

        [Fact]
        public void Should_find_max_correctly_when_some_numbers()
        {
            var expectedArray = 77;
            var array = new[] { 77, -20, 60, 8, 77 };
            var actualArray = ArrayHelpers.FindMax(array);
            actualArray.Equals(expectedArray);
        }
    }
}
