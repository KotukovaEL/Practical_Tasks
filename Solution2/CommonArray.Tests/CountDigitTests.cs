using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CommonArray.Tests
{
    public class CountDigitTests
    {
        [Fact]
        public void Should_find_quantity_digit_correctly()
        {
            var expectedArray = 6;
            var array = new[] { 10, 17, 85, 75, 11, 51, 66, 71, 91 };
            var digit = 1;
            var actualArray = ArrayHelpers.CountDigit(array, digit);
            actualArray.Equals(expectedArray);
        }

        [Fact]
        public void Should_find_quantity_digit_correctly_when_no_this_numbers()
        {
            var expectedArray = 0;
            var array = new[] { 55, 7, 85, 75, 24, 56, 66, 88, 92 };
            var digit = 1;
            var actualArray = ArrayHelpers.CountDigit(array, digit);
            actualArray.Equals(expectedArray);
        }
    }
}
