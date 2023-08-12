using Xunit;

namespace CommonArray.Tests
{
    public class FindNumberOfOddNumbersTests
    {
        [Fact]
        public void Should_find_not_even_numbers_correctly()
        {
            var expectedArray = 2;
            var array = new[] { 1, 2, 3 };
            var actualArray = ArrayHelpers.FindNumberOfOddNumbers(array);
            actualArray.Equals(expectedArray);
        }

        [Fact]
        public void Should_find_not_even_numbers_correctly_when_all_number_even()
        {
            var expectedArray = 0;
            var array = new[] { 2, 4, 6, 8 };
            var actualArray = ArrayHelpers.FindNumberOfOddNumbers(array);
            actualArray.Equals(expectedArray);
        }
    }
}
