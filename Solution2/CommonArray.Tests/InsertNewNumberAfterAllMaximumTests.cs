using FluentAssertions;
using Xunit;

namespace CommonArray.Tests
{
    public class InsertNewNumberAfterAllMaximumTests
    {
        [Fact]
        public void Should_paste_new_number_after_max_correctly()
        {
            var expectedArray = new[] { 1, 2, 3, 1111 };
            var maxNumber = 3;
            var quantityMaxNumber = 1;
            var newNumber = 1111;
            var array = new[] { 1, 2, 3 };
            var actualArray = ArrayHelpers.InsertNewNumberAfterAllMaximum(array, maxNumber, quantityMaxNumber, newNumber);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_paste_new_number_after_max_correctly_when_some_this_numbers()
        {
            var expectedArray = new[] { 1, 7, 1111, 2, 3, 7, 1111, 7, 1111 };
            var maxNumber = 7;
            var quantityMaxNumber = 3;
            var newNumber = 1111;
            var array = new[] { 1, 7, 2, 3, 7, 7 };
            var actualArray = ArrayHelpers.InsertNewNumberAfterAllMaximum(array, maxNumber, quantityMaxNumber, newNumber);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }
    }
}
