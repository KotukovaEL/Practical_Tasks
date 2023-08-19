using FluentAssertions;
using Xunit;

namespace CommonArray.Tests
{
    public class InsertBeforeElementsWithDigitTests
    {
        [Fact]
        public void Should_paste_new_number_before_elements_with_digit_correctly()
        {
            var expectedArray = new[] { 333, 1, 2, 333, 51, 857 };
            var newNumber = 333;
            var quantityDigit = 2;
            var digit = 1;
            var array = new[] { 1, 2, 51, 857 };
            var actualArray = ArrayHelpers.InsertBeforeElementsWithDigit(array, newNumber, digit, quantityDigit);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_paste_new_number_before_elements_with_digit_correctly_when_all_this()
        {
            var expectedArray = new[] { 333, 1, 333, 21, 333, 51, 333, 811 };
            var newNumber = 333;
            var quantityDigit = 4;
            var digit = 1;
            var array = new[] { 1, 21, 51, 811 };
            var actualArray = ArrayHelpers.InsertBeforeElementsWithDigit(array, newNumber, digit, quantityDigit);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }
    }
}
