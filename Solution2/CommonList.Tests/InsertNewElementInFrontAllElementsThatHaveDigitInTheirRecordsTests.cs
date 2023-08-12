using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CommonList.Tests
{
    public class InsertNewElementInFrontAllElementsThatHaveDigitInTheirRecordsTests
    {
        [Fact]
        public void Should_paste_new_number_before_elements_with_digit_correctly()
        {
            var expectedList = new List<int> { 333, 1, 2, 333, 51, 857 };
            var newNumber = 333;
            var digit = 1;
            var list = new List<int> { 1, 2, 51, 857 };
            var actualList = ListHelpers.InsertNewElementInFrontAllElementsThatHaveDigitInTheirRecords(list, newNumber, digit);
            actualList.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_paste_new_number_before_elements_with_digit_correctly_when_all_this()
        {
            var expectedList = new List<int> { 333, 1, 333, 21, 333, 51, 333, 811 };
            var newNumber = 333;
            var digit = 1;
            var list = new List<int> { 1, 21, 51, 811 };
            var actualList = ListHelpers.InsertNewElementInFrontAllElementsThatHaveDigitInTheirRecords(list, newNumber, digit);
            actualList.Should().BeEquivalentTo(expectedList);
        }
    }
}
