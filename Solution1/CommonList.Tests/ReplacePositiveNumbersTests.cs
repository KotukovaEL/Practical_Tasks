using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CommonList.Tests
{
    public class ReplacePositiveNumbersTests
    {
        [Fact]
        public void Should_replace_numbers_correctly_when_all_numbers_positive()
        {
            var expectedList = new List<int> { 111, 111, 111, 111, 111, 111, 111 };
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            var number = 111;
            ListHelpers.ReplacePositiveNumbers(list, number);
            //Assert.Equal(expectedArray, actualArray);
            list.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_replace_numbers_correctly_when_number_different()
        {
            var expectedList = new List<int> { -10, 111, -5, -6, 111, 111, 0 };
            var list = new List<int> { -10, 2, -5, -6, 5, 6, 0 };
            var number = 111;
            ListHelpers.ReplacePositiveNumbers(list, number);
            //Assert.Equal(expectedArray, actualArray);
            list.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_replace_numbers_correctly_when_all_number_negative()
        {
            var expectedList = new List<int> { -10, -9, -5, -6, -8, -7, -1 };
            var list = new List<int> { -10, -9, -5, -6, -8, -7, -1 };
            var number = 111;
            ListHelpers.ReplacePositiveNumbers(list, number);
            //Assert.Equal(expectedArray, actualArray);
            list.Should().BeEquivalentTo(expectedList);
        }
    }
}
