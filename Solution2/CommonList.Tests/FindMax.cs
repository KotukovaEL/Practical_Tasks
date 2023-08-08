using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CommonList;


namespace CommonList.Tests
{
    public class FindMax
    {
        [Fact]
        public void Should_find_max_correctly_when_one_number()
        {
            var expectedList = 77;
            var list = new List<int> { 55, -20, 60, 8, 77 };
            var actualList = ListHelpers.FindMax(list);
            actualList.Equals(expectedList);
        }

        [Fact]
        public void Should_find_max_correctly_when_some_numbers()
        {
            var expectedList = 77;
            var list = new List<int> { 77, -20, 60, 8, 77 };
            var actualList = ListHelpers.FindMax(list);
            actualList.Equals(expectedList);
        }
    }

    public class FindCountMaxNumber
    {
        [Fact]
        public void Should_find_quantity_max_correctly_when_one_number()
        {
            var expectedList = 4;
            var list = new List<int> { 10, -20, 10, 8, 10, 10, 5, 22 };
            var maxNumber = 10;
            var actualList = ListHelpers.FindCountMaxNumber(list, maxNumber);
            actualList.Equals(expectedList);
        }

        [Fact]
        public void Should_find_max_correctly_when_all_numbers_max()
        {
            var expectedList = 5;
            var list = new List<int> { 10, 10, 10, 10, 10 };
            var maxNumber = 10;
            var actualList = ListHelpers.FindCountMaxNumber(list, maxNumber);
            actualList.Equals(expectedList);
        }
    }

    public class FindNumberOfOddNumbers
    {
        [Fact]
        public void Should_find_number_of_odd_numbers_correctly()
        {
            var expectedList = 1;
            var list = new List<int> { 10, -20, 10, 8, 10, 10, 5, 22 };
            var actualList = ListHelpers.FindNumberOfOddNumbers(list);
            actualList.Equals(expectedList);
        }

        [Fact]
        public void Should_find_number_of_odd_numbers_correctly_some_numbers()
        {
            var expectedList = 4;
            var list = new List<int> { 10, -20, 10, 8, 10, 10, 5, 22, 55, 77, 9 };
            var actualList = ListHelpers.FindNumberOfOddNumbers(list);
            actualList.Equals(expectedList);
        }
    }

    public class DeleteEvenNumbers
    {
        [Fact]
        public void Should_remove_even_numbers_correctly()
        {
            var expectedList = new List<int> { 1, 3, 5, 7, 9, 11 };
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var actualList = ListHelpers.DeleteEvenNumbers(list);
            actualList.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_remove_even_numbers_correctly_when_no_this_numbers()
        {
            var expectedList = new List<int> { 1, 3, 5, 7, 9, 11 };
            var list = new List<int> { 1, 3, 5, 7, 9, 11 };
            var actualList = ListHelpers.DeleteEvenNumbers(list);
            actualList.Should().BeEquivalentTo(expectedList);
        }
    }

    public class InsertNewElementAfterAllMaximum
    {
        [Fact]
        public void Should_paste_new_number_after_max_correctly()
        {
            var expectedList = new List<int> { 1, 2, 3, 1111 };
            var maxNumber = 3;
            var quantityMaxNumber = 1;
            var newNumber = 1111;
            var list = new List<int> { 1, 2, 3 };
            var actualList = ListHelpers.InsertNewElementAfterAllMaximum(list, maxNumber, newNumber, quantityMaxNumber );
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
            var actualList = ListHelpers.InsertNewElementAfterAllMaximum(list, maxNumber, newNumber, quantityMaxNumber );
            actualList.Should().BeEquivalentTo(expectedList);
        }
    }

    public class RemoveMaxElements
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

    public class InsertNewElementInFrontAllElementsThatHaveDigitInTheirRecords
    {
        [Fact]
        public void Should_paste_new_number_before_elements_with_digit_correctly()
        {
            var expectedList = new List<int> { 333, 1, 2, 333, 51, 857 };
            var newNumber = 333;
            var digit = 1;
            var list = new List<int> {  1, 2, 51, 857 };
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

    public class RemoveElements
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
