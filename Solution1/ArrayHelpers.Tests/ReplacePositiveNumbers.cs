using FluentAssertions;
using Xunit;

namespace CommonArray.Tests
{
    public class ReplacePositiveNumbers
    {
        [Fact]
        public void Should_replace_numbers_correctly_when_all_numbers_positive()
        {
            var expectedArray = new[] { 111, 111, 111, 111, 111, 111, 111 };
            var array = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var number = 111;
            ArrayHelpers.ReplacePositiveNumbers(array, number);
            //Assert.Equal(expectedArray, actualArray);
            array.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_replace_numbers_correctly_when_number_different()
        {
            var expectedArray = new[] { -10, 111, -5, -6, 111, 111, 0 };
            var array = new[] { -10, 2, -5, -6, 5, 6, 0 };
            var number = 111;
            ArrayHelpers.ReplacePositiveNumbers(array, number);
            //Assert.Equal(expectedArray, actualArray);
            array.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_replace_numbers_correctly_when_all_number_negative()
        {
            var expectedArray = new[] { -10, -9, -5, -6, -8, -7, -1 };
            var array = new[] { -10, -9, -5, -6, -8, -7, -1 };
            var number = 111;
            ArrayHelpers.ReplacePositiveNumbers(array, number);
            //Assert.Equal(expectedArray, actualArray);
            array.Should().BeEquivalentTo(expectedArray);
        }
    }
}
