using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CommonArray;

namespace CommonArray.Tests
{
    public class FindMax
    {
        [Fact]
        public void Should_find_max_correctly_when_one_number()
        {
            var expectedArray = 77;
            var array = new[] { 55, -20, 60, 8, 77 };
            var actualArray = ArrayHelpers.FindMax(array);
            actualArray.Equals(expectedArray);
        }

        [Fact]
        public void Should_find_max_correctly_when_some_numbers()
        {
            var expectedArray = 77;
            var array = new[] { 77, -20, 60, 8, 77 };
            var actualArray = ArrayHelpers.FindMax(array);
            actualArray.Equals(expectedArray);
        }
    }

    public class FindNumberOfMaximumNumbers
    {
        [Fact]
        public void Should_find_quantity_max_correctly()
        {
            var expectedArray = 4;
            var array = new[] { 10, -20, 10, 8, 10, 10, 5, 22 };
            var maxNumber = 10;
            var actualArray = ArrayHelpers.FindNumberOfMaximumNumbers(array, maxNumber);
            actualArray.Equals(expectedArray);
        }

        [Fact]
        public void Should_find_max_correctly_when_all_numbers_max()
        {
            var expectedArray = 5;
            var array = new[] { 10, 10, 10, 10, 10 };
            var maxNumber = 10;
            var actualArray = ArrayHelpers.FindNumberOfMaximumNumbers(array, maxNumber);
            actualArray.Equals(expectedArray);
        }
    }

    public class SelectOddNumbers
    {
        [Fact]
        public void Should_remove_even_numbers_correctly()
        {
            var expectedArray = new[] { 1, 3, 5, 7, 9, 11 };
            var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var quantityNotEvenNumber = 6;
            var actualArray = ArrayHelpers.SelectOddNumbers(array, quantityNotEvenNumber);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_remove_even_numbers_correctly_when_no_this_numbers()
        {
            var expectedArray = new[] { 1, 3, 5, 7, 9, 11, 13 };
            var array = new[] { 1, 3, 5, 7, 9, 11, 13 };
            var quantityNotEvenNumber = 7;
            var actualArray = ArrayHelpers.SelectOddNumbers(array, quantityNotEvenNumber);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }
    }

    public class FindNumberOfOddNumbers
    {
        [Fact]
        public void Should_find_not_even_numbers_correctly()
        {
            var expectedArray = 2;
            var array = new[] { 1, 2, 3 };
            var actualArray = ArrayHelpers.FindNumberOfOddNumbers(array);
            actualArray.Equals(expectedArray);
        }

        [Fact]
        public void Should_find_not_even_numbers_correctly_when_all_number_even()
        {
            var expectedArray = 0;
            var array = new[] {  2, 4, 6, 8 };
            var actualArray = ArrayHelpers.FindNumberOfOddNumbers(array);
            actualArray.Equals(expectedArray);
        }
    }

    public class InsertNewNumberAfterAllMaximum
    {
        [Fact]
        public void Should_paste_new_number_after_max_correctly()
        {
            var expectedArray = new[] { 1, 2, 3, 1111 };
            var maxNumber = 3;
            var quantityMaxNumber = 1;
            var newNumber = 1111;
            var array = new[] { 1, 2, 3 };
            var actualArray = ArrayHelpers.InsertNewNumberAfterAllMaximum(array, maxNumber, quantityMaxNumber,newNumber);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_paste_new_number_after_max_correctly_when_some_this_numbers()
        {
            var expectedArray = new[] { 1, 7, 1111, 2, 3, 7, 1111, 7, 1111 };
            var maxNumber = 7;
            var quantityMaxNumber = 3;
            var newNumber = 1111;
            var array = new[] { 1, 7, 2, 3, 7, 7 };
            var actualArray = ArrayHelpers.InsertNewNumberAfterAllMaximum(array, maxNumber, quantityMaxNumber, newNumber);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }
    }

    public class RemoveMaximumNumbers
    {
        [Fact]
        public void Should_remove_max_number_correctly()
        {
            var expectedArray = new[] { 1, 2};
            var maxNumber = 3;
            var quantityMaxNumber = 1;
            var array = new[] { 1, 2, 3 };
            var actualArray = ArrayHelpers.RemoveMaximumNumbers(array, maxNumber, quantityMaxNumber);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_remove_max_number_correctly_when_some_max_number()
        {
            var expectedArray = new[] { 1, 2, 5, 4, 3 };
            var maxNumber = 6;
            var quantityMaxNumber = 3;
            var array = new[] { 6, 1, 2, 6, 6, 5, 4, 3 };
            var actualArray = ArrayHelpers.RemoveMaximumNumbers(array, maxNumber, quantityMaxNumber);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }
    }

    public class CountDigit
    {
        [Fact]
        public void Should_find_quantity_digit_correctly()
        {
            var expectedArray = 6;
            var array = new[] { 10, 17, 85, 75, 11, 51, 66, 71, 91};
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

    public class InsertBeforeElementsWithDigit
    {
        [Fact]
        public void Should_paste_new_number_before_elements_with_digit_correctly()
        {
            var expectedArray = new[] { 333, 1, 2, 333, 51, 857 };
            var newNumber = 333;
            var quantityDigit = 2;
            var digit =  1;
            var array = new[] { 1, 2, 51, 857 };
            var actualArray = ArrayHelpers.InsertBeforeElementsWithDigit(array, newNumber, digit, quantityDigit);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_paste_new_number_before_elements_with_digit_correctly_when_all_this()
        {
            var expectedArray = new[] { 333, 1, 333, 21, 333, 51, 333, 811 };
            var newNumber = 333;
            var quantityDigit = 4;
            var digit = 1;
            var array = new[] { 1, 21, 51, 811 };
            var actualArray = ArrayHelpers.InsertBeforeElementsWithDigit(array, newNumber, digit, quantityDigit);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }
    }

    public class RemoveElementsFromK1ToK2
    {
        [Fact]
        public void Should_remove_elements_from_k1_to_k2_correctly()
        {
            var expectedArray = new[] { 1, 5, 6, 7 };
            var k1 = 1;
            var k2 = 3;
            var array = new[] { 1, 2, 3, 4, 5, 6, 7 };
            ArrayHelpers.RemoveElementsFromK1ToK2(ref array, k1, k2);
            ref var actualArray = ref array;
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_remove_elements_from_k1_to_k2_correctly_when_first_element()
        {
            var expectedArray = new[] { 2, 3, 4, 5, 6, 7 };
            var k1 = 0;
            var k2 = 0;
            var array = new[] { 1, 2, 3, 4, 5, 6, 7 };
            ArrayHelpers.RemoveElementsFromK1ToK2(ref array, k1, k2);
            ref var actualArray = ref array;
            actualArray.Should().BeEquivalentTo(expectedArray);
        }
    }
}
