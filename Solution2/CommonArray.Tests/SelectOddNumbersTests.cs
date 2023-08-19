using FluentAssertions;
using Xunit;

namespace CommonArray.Tests
{
    public class SelectOddNumbersTests
    {
        [Fact]
        public void Should_remove_even_numbers_correctly()
        {
            var expectedArray = new[] { 1, 3, 5, 7, 9, 11 };
            var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var quantityNotEvenNumber = 6;
            var actualArray = ArrayHelpers.SelectOddNumbers(array, quantityNotEvenNumber);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_remove_even_numbers_correctly_when_no_this_numbers()
        {
            var expectedArray = new[] { 1, 3, 5, 7, 9, 11, 13 };
            var array = new[] { 1, 3, 5, 7, 9, 11, 13 };
            var quantityNotEvenNumber = 7;
            var actualArray = ArrayHelpers.SelectOddNumbers(array, quantityNotEvenNumber);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }
    }
}
