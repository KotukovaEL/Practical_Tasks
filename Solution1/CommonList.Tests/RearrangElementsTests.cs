using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CommonList.Tests
{
    public class RearrangElementsTests
    {
        [Fact]
        public void Should_rearrang_elements_correctly_1()
        {
            var expectedList = new List<int> { 2, 1, 4, 3, 6, 5, 8, 7 };
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            ListHelpers.RearrangElements(list);
            //Assert.Equal(expectedArray, actualArray);
            list.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_rearrang_elements_correctly_2()
        {
            var expectedList = new List<int> { -6, 5, 7, 8, 21, 74 };
            var list = new List<int> { 5, -6, 8, 7, 74, 21 };
            ListHelpers.RearrangElements(list);
            //Assert.Equal(expectedArray, actualArray);
            list.Should().BeEquivalentTo(expectedList);
        }
    }
}
