using System.Collections.Generic;
using Xunit;

namespace CommonList.Tests
{
    public class FindCountMaxNumberTests
    {
        [Fact]
        public void Should_find_quantity_max_correctly_when_one_number()
        {
            var expectedList = 4;
            var list = new List<int> { 10, -20, 10, 8, 10, 10, 5, 22 };
            var maxNumber = 10;
            var actualList = ListHelpers.FindCountMaxNumber(list, maxNumber);
            actualList.Equals(expectedList);
        }

        [Fact]
        public void Should_find_max_correctly_when_all_numbers_max()
        {
            var expectedList = 5;
            var list = new List<int> { 10, 10, 10, 10, 10 };
            var maxNumber = 10;
            var actualList = ListHelpers.FindCountMaxNumber(list, maxNumber);
            actualList.Equals(expectedList);
        }
    }
}
