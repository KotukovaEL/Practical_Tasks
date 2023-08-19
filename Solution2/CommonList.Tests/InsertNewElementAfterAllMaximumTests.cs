using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CommonList.Tests
{
    public class InsertNewElementAfterAllMaximumTests
    {
        [Fact]
        public void Should_paste_new_number_after_max_correctly()
        {
            var expectedList = new List<int> { 1, 2, 3, 1111 };
            var maxNumber = 3;
            var quantityMaxNumber = 1;
            var newNumber = 1111;
            var list = new List<int> { 1, 2, 3 };
            var actualList = ListHelpers.InsertNewElementAfterAllMaximum(list, maxNumber, newNumber, quantityMaxNumber);
            actualList.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_paste_new_number_after_max_correctly_when_some_this_numbers()
        {
            var expectedList = new List<int> { 1, 7, 1111, 2, 3, 7, 1111, 7, 1111 };
            var maxNumber = 7;
            var quantityMaxNumber = 3;
            var newNumber = 1111;
            var list = new List<int> { 1, 7, 2, 3, 7, 7 };
            var actualList = ListHelpers.InsertNewElementAfterAllMaximum(list, maxNumber, newNumber, quantityMaxNumber);
            actualList.Should().BeEquivalentTo(expectedList);
        }
    }
}
