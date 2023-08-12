using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CommonList.Tests
{
    public class ReplaceEvenElementsTests
    {
        [Fact]
        public void Should_replace_even_elements_correctly_when_all_numbers_even()
        {
            var expectedList = new List<int> { 222, 222, 222, 222, 222, 222, 222 };
            var list = new List<int> { 22, 34, 2, -10, 10, 52, 98 };
            var number = 222;
            ListHelpers.ReplaceEvenElements(list, number);
            //Assert.Equal(expectedArray, actualArray);
            list.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_replace_even_numbers_correctly_when_number_different()
        {
            var expectedList = new List<int> { 222, 222, 222, -75, 111, 67, 79 };
            var list = new List<int> { -152, 46, 78, -75, 111, 67, 79 };
            var number = 222;
            ListHelpers.ReplaceEvenElements(list, number);
            //Assert.Equal(expectedArray, actualArray);
            list.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_replace_even_numbers_correctly_when_all_numbers_not_even()
        {
            var expectedList = new List<int> { -11, -9, -5, -9, -5, -7, -1 };
            var list = new List<int> { -11, -9, -5, -9, -5, -7, -1 };
            var number = 111;
            ListHelpers.ReplaceEvenElements(list, number);
            //Assert.Equal(expectedArray, actualArray);
            list.Should().BeEquivalentTo(expectedList);
        }
    }
}
