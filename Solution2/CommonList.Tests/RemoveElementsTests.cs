using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CommonList.Tests
{
    public class RemoveElementsTests
    {

        [Fact]
        public void Should_remove_elements_from_k1_to_k2_correctly()
        {
            var expectedList = new List<int> { 1, 5, 6, 7 };
            var k1 = 1;
            var k2 = 3;
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            var actualList = ListHelpers.RemoveElements(list, k1, k2);
            actualList.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_remove_elements_from_k1_to_k2_correctly_when_first_element()
        {
            var expectedList = new List<int> { 2, 3, 4, 5, 6, 7 };
            var k1 = 0;
            var k2 = 0;
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            var actualList = ListHelpers.RemoveElements(list, k1, k2);
            actualList.Should().BeEquivalentTo(expectedList);
        }
    }
}
