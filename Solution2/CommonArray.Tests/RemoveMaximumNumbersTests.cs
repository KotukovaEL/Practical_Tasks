using FluentAssertions;
using Xunit;

namespace CommonArray.Tests
{
    public class RemoveMaximumNumbersTests
    {
        [Fact]
        public void Should_remove_max_number_correctly()
        {
            var expectedArray = new[] { 1, 2 };
            var maxNumber = 3;
            var quantityMaxNumber = 1;
            var array = new[] { 1, 2, 3 };
            var actualArray = ArrayHelpers.RemoveMaximumNumbers(array, maxNumber, quantityMaxNumber);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_remove_max_number_correctly_when_some_max_number()
        {
            var expectedArray = new[] { 1, 2, 5, 4, 3 };
            var maxNumber = 6;
            var quantityMaxNumber = 3;
            var array = new[] { 6, 1, 2, 6, 6, 5, 4, 3 };
            var actualArray = ArrayHelpers.RemoveMaximumNumbers(array, maxNumber, quantityMaxNumber);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }
    }
}
