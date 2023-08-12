using System.Collections.Generic;
using Xunit;

namespace CommonList.Tests
{
    public class FindNumberOfOddNumbersTests
    {

        [Fact]
        public void Should_find_number_of_odd_numbers_correctly()
        {
            var expectedList = 1;
            var list = new List<int> { 10, -20, 10, 8, 10, 10, 5, 22 };
            var actualList = ListHelpers.FindNumberOfOddNumbers(list);
            actualList.Equals(expectedList);
        }

        [Fact]
        public void Should_find_number_of_odd_numbers_correctly_some_numbers()
        {
            var expectedList = 4;
            var list = new List<int> { 10, -20, 10, 8, 10, 10, 5, 22, 55, 77, 9 };
            var actualList = ListHelpers.FindNumberOfOddNumbers(list);
            actualList.Equals(expectedList);
        }
    }
}
