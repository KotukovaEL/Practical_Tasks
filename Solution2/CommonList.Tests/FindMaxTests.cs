using System.Collections.Generic;
using Xunit;


namespace CommonList.Tests
{
    public class FindMaxTests
    {
        [Fact]
        public void Should_find_max_correctly_when_one_number()
        {
            var expectedList = 77;
            var list = new List<int> { 55, -20, 60, 8, 77 };
            var actualList = ListHelpers.FindMax(list);
            actualList.Equals(expectedList);
        }

        [Fact]
        public void Should_find_max_correctly_when_some_numbers()
        {
            var expectedList = 77;
            var list = new List<int> { 77, -20, 60, 8, 77 };
            var actualList = ListHelpers.FindMax(list);
            actualList.Equals(expectedList);
        }
    }
}
