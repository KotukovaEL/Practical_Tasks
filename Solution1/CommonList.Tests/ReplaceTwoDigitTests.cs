using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CommonList.Tests
{
    public class ReplaceTwoDigitTests
    {
        [Fact]
        public void Should_replace_two_digit_elements_correctly()
        {
            var expectedList = new List<int> { 112, 1111, 995, 1111, 1, 1111, 1111 };
            var list = new List<int> { 112, -10, 995, 55, 1, 37, 99 };
            var number = 1111;
            ListHelpers.ReplaceTwoDigit(list, number);
            //Assert.Equal(expectedArray, actualArray);
            list.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_replace_two_digit_elements_correctly_when_all_two_digit_numbers()
        {
            var expectedList = new List<int> { 1111, 1111, 1111, 1111, 1111, 1111, 1111 };
            var list = new List<int> { -99, 10, 25, 88, 17, 74, 42 };
            var number = 1111;
            ListHelpers.ReplaceTwoDigit(list, number);
            //Assert.Equal(expectedArray, actualArray);
            list.Should().BeEquivalentTo(expectedList);
        }
    }
}
