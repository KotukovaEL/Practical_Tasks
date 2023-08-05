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
    public class ReplacePositiveNumbers
    {
        [Fact]
        public void Should_replace_numbers_correctly_when_all_numbers_positive()
        {
            var expectedList = new List<int> { 111, 111, 111, 111, 111, 111, 111 };
            var list = new List<int>  { 1, 2, 3, 4, 5, 6, 7 };
            var number = 111;
            ListHelpers.ReplacePositiveNumbers(list, number);
            ref var actualList = ref list;
            //Assert.Equal(expectedArray, actualArray);
            actualList.Should().BeEquivalentTo(expectedList);
        }
  
        [Fact]
        public void Should_replace_numbers_correctly_when_number_different()
        {
            var expectedList = new List<int> { -10, 111, -5, -6, 111, 111, 0 };
            var list = new List<int> { -10, 2, -5, -6, 5, 6, 0 };
            var number = 111;
            ListHelpers.ReplacePositiveNumbers(list, number);
            ref var actualList = ref list;
            //Assert.Equal(expectedArray, actualArray);
            actualList.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_replace_numbers_correctly_when_all_number_negative()
        {
            var expectedList = new List<int> { -10, -9, -5, -6, -8, -7, -1 };
            var list = new List<int> { -10, -9, -5, -6, -8, -7, -1 };
            var number = 111;
            ListHelpers.ReplacePositiveNumbers(list, number);
            ref var actualList = ref list;
            //Assert.Equal(expectedArray, actualArray);
            actualList.Should().BeEquivalentTo(expectedList);
        }

        public class ReplaceEvenElements
        {
            [Fact]
            public void Should_replace_even_elements_correctly_when_all_numbers_even()
            {
                var expectedList = new List<int> { 222, 222, 222, 222, 222, 222, 222 };
                var list = new List<int> { 22, 34, 2, -10, 10, 52, 98 };
                var number = 222;
                ListHelpers.ReplaceEvenElements(list, number);
                ref var actualList = ref list;
                //Assert.Equal(expectedArray, actualArray);
                actualList.Should().BeEquivalentTo(expectedList);
            }

            [Fact]
            public void Should_replace_even_numbers_correctly_when_number_different()
            {
                var expectedList = new List<int> { 222, 222, 222, -75, 111, 67, 79 };
                var list = new List<int> { -152, 46, 78, -75, 111, 67, 79 };
                var number = 222;
                ListHelpers.ReplaceEvenElements(list, number);
                ref var actualList = ref list;
                //Assert.Equal(expectedArray, actualArray);
                actualList.Should().BeEquivalentTo(expectedList);
            }

            [Fact]
            public void Should_replace_even_numbers_correctly_when_all_numbers_not_even()
            {
                var expectedList = new List<int> { -11, -9, -5, -9, -5, -7, -1 };
                var list = new List<int> { -11, -9, -5, -9, -5, -7, -1 };
                var number = 111;
                ListHelpers.ReplaceEvenElements(list, number);
                ref var actualList = ref list;
                //Assert.Equal(expectedArray, actualArray);
                actualList.Should().BeEquivalentTo(expectedList);
            }
        }

        public class RearrangElements
        {
            [Fact]
            public void Should_rearrang_elements_correctly_1()
            {
                var expectedList = new List<int> { 2, 1, 4, 3, 6, 5, 8, 7 };
                var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
                ListHelpers.RearrangElements(list);
                ref var actualArray = ref list;
                //Assert.Equal(expectedArray, actualArray);
                actualArray.Should().BeEquivalentTo(expectedList);
            }

            [Fact]
            public void Should_rearrang_elements_correctly_2()
            {
                var expectedList = new List<int> { -6, 5, 7, 8, 21, 74 };
                var list = new List<int> { 5, -6, 8, 7, 74, 21 };
                ListHelpers.RearrangElements(list);
                ref var actualArray = ref list;
                //Assert.Equal(expectedArray, actualArray);
                actualArray.Should().BeEquivalentTo(expectedList);
            }
        }

        public class ReplaceTwoDigit
        {
            [Fact]
            public void Should_replace_two_digit_elements_correctly()
            {                
                var expectedList = new List<int> { 112, 1111, 995, 1111, 1, 1111, 1111 };
                var list = new List<int> { 112, -10, 995, 55, 1, 37, 99 };
                var number = 1111;
                ListHelpers.ReplaceTwoDigit(list, number);
                ref var actualArray = ref list;
                //Assert.Equal(expectedArray, actualArray);
                actualArray.Should().BeEquivalentTo(expectedList);
            }

            [Fact]
            public void Should_replace_two_digit_elements_correctly_when_all_two_digit_numbers()
            {
                var expectedList = new List<int> { 1111, 1111, 1111, 1111, 1111, 1111, 1111 };
                var list = new List<int> { -99, 10, 25, 88, 17, 74, 42 };
                var number = 1111;
                ListHelpers.ReplaceTwoDigit(list, number);
                ref var actualArray = ref list;
                //Assert.Equal(expectedArray, actualArray);
                actualArray.Should().BeEquivalentTo(expectedList);
            }
        }
    }
}
