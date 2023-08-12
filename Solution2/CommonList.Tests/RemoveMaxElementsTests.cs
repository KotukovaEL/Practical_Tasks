using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CommonList.Tests
{
    public class RemoveMaxElementsTests
    {
        [Fact]
        public void Should_remove_max_number_correctly()
        {
            var expectedList = new List<int> { 1, 2 };
            var maxNumber = 3;
            var list = new List<int> { 1, 2, 3 };
            var actualList = ListHelpers.RemoveMaxElements(list, maxNumber);
            actualList.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_remove_max_number_correctly_when_some_max_number()
        {
            var expectedList = new List<int> { 1, 2, 5, 4, 3 };
            var maxNumber = 6;
            var list = new List<int> { 6, 1, 2, 6, 6, 5, 4, 3 };
            var actualList = ListHelpers.RemoveMaxElements(list, maxNumber);
            actualList.Should().BeEquivalentTo(expectedList);
        }
    }
}
