using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CommonList.Tests
{
    public class DeleteEvenNumbersTests
    {
        [Fact]
        public void Should_remove_even_numbers_correctly()
        {
            var expectedList = new List<int> { 1, 3, 5, 7, 9, 11 };
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var actualList = ListHelpers.DeleteEvenNumbers(list);
            actualList.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_remove_even_numbers_correctly_when_no_this_numbers()
        {
            var expectedList = new List<int> { 1, 3, 5, 7, 9, 11 };
            var list = new List<int> { 1, 3, 5, 7, 9, 11 };
            var actualList = ListHelpers.DeleteEvenNumbers(list);
            actualList.Should().BeEquivalentTo(expectedList);
        }
    }
}
