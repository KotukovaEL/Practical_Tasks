using FluentAssertions;
using Xunit;

namespace CommonArray.Tests
{
    public class ReplaceEvenElementsTests
    {
        [Fact]
        public void Should_replace_even_elements_correctly_when_all_numbers_even()
        {
            var expectedArray = new[] { 222, 222, 222, 222, 222, 222, 222 };
            var array = new[] { 22, 34, 2, -10, 10, 52, 98 };
            var number = 222;
            var actualArray = ArrayHelpers.ReplaceEvenElements(array, number);
            //Assert.Equal(expectedArray, actualArray);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_replace_even_numbers_correctly_when_number_different()
        {
            var expectedArray = new[] { 222, 222, 222, -75, 111, 67, 79 };
            var array = new[] { -152, 46, 78, -75, 111, 67, 79 };
            var number = 222;
            var actualArray = ArrayHelpers.ReplaceEvenElements(array, number);
            //Assert.Equal(expectedArray, actualArray);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_replace_even_numbers_correctly_when_all_numbers_not_even()
        {
            var expectedArray = new[] { -11, -9, -5, -9, -5, -7, -1 };
            var array = new[] { -11, -9, -5, -9, -5, -7, -1 };
            var number = 111;
            var actualArray = ArrayHelpers.ReplaceEvenElements(array, number);
            //Assert.Equal(expectedArray, actualArray);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }
    }
}
