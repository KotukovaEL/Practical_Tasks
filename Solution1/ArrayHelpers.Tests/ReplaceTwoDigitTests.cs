using FluentAssertions;
using Xunit;

namespace CommonArray.Tests
{
    public class ReplaceTwoDigitTests
    {
        [Fact]
        public void Should_replace_two_digit_elements_correctly()
        {
            var expectedArray = new[] { 112, 1111, 995, 1111, 1, 1111, 1111 };
            var array = new[] { 112, -10, 995, 55, 1, 37, 99 };
            var number = 1111;
            ArrayHelpers.ReplaceTwoDigit(array, number);
            //Assert.Equal(expectedArray, actualArray);
            array.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_replace_two_digit_elements_correctly_when_all_two_digit_numbers()
        {
            var expectedArray = new[] { 1111, 1111, 1111, 1111, 1111, 1111, 1111 };
            var array = new[] { -99, 10, 25, 88, 17, 74, 42 };
            var number = 1111;
            ArrayHelpers.ReplaceTwoDigit(array, number);
            //Assert.Equal(expectedArray, actualArray);
            array.Should().BeEquivalentTo(expectedArray);
        }
    }
}
