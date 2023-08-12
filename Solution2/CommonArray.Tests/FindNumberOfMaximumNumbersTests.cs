using Xunit;

namespace CommonArray.Tests
{
    public class FindNumberOfMaximumNumbersTests
    {
        [Fact]
        public void Should_find_quantity_max_correctly()
        {
            var expectedArray = 4;
            var array = new[] { 10, -20, 10, 8, 10, 10, 5, 22 };
            var maxNumber = 10;
            var actualArray = ArrayHelpers.FindNumberOfMaximumNumbers(array, maxNumber);
            actualArray.Equals(expectedArray);
        }

        [Fact]
        public void Should_find_max_correctly_when_all_numbers_max()
        {
            var expectedArray = 5;
            var array = new[] { 10, 10, 10, 10, 10 };
            var maxNumber = 10;
            var actualArray = ArrayHelpers.FindNumberOfMaximumNumbers(array, maxNumber);
            actualArray.Equals(expectedArray);
        }
    }
}
