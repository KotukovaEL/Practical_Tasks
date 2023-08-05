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
    public class ReplacePositiveNumbers
    {
        [Fact]
        public void Should_replace_numbers_correctly_when_all_numbers_positive()
        {
            var expectedArray = new[] { 111, 111, 111, 111, 111, 111, 111 };
            var array = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var number = 111;
            ArrayHelpers.ReplacePositiveNumbers(array, number);
            ref var actualArray = ref array;
            //Assert.Equal(expectedArray, actualArray);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_replace_numbers_correctly_when_number_different()
        {
            var expectedArray = new[] { -10, 111, -5, -6, 111, 111, 0 };
            var array = new[] { -10, 2, -5, -6, 5, 6, 0 };
            var number = 111;
            ArrayHelpers.ReplacePositiveNumbers(array, number);
            ref var actualArray = ref array;
            //Assert.Equal(expectedArray, actualArray);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_replace_numbers_correctly_when_all_number_negative()
        {
            var expectedArray = new[] { -10, -9, -5, -6, -8, -7, -1 };
            var array = new[] { -10, -9, -5, -6, -8, -7, -1 };
            var number = 111;
            ArrayHelpers.ReplacePositiveNumbers(array, number);
            ref var actualArray = ref array;
            //Assert.Equal(expectedArray, actualArray);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }

        public class ReplaceEvenElements
        {
            [Fact]
            public void Should_replace_even_elements_correctly_when_all_numbers_even()
            {
                var expectedArray = new[] { 222, 222, 222, 222, 222, 222, 222 };
                var array = new[] { 22, 34, 2, -10, 10, 52, 98 };
                var number = 222;
                var actualArray = ArrayHelpers.ReplaceEvenElements(array, number);
                //Assert.Equal(expectedArray, actualArray);
                actualArray.Should().BeEquivalentTo(expectedArray);
            }

            [Fact]
            public void Should_replace_even_numbers_correctly_when_number_different()
            {
                var expectedArray = new[] { 222, 222, 222, -75, 111, 67, 79 };
                var array = new[] { -152, 46, 78, -75, 111, 67, 79 };
                var number = 222;
                var actualArray = ArrayHelpers.ReplaceEvenElements(array, number);
                //Assert.Equal(expectedArray, actualArray);
                actualArray.Should().BeEquivalentTo(expectedArray);
            }

            [Fact]
            public void Should_replace_even_numbers_correctly_when_all_numbers_not_even()
            {
                var expectedArray = new[] { -11, -9, -5, -9, -5, -7, -1 };
                var array = new[] { -11, -9, -5, -9, -5, -7, -1 };
                var number = 111;
                var actualArray = ArrayHelpers.ReplaceEvenElements(array, number);
                //Assert.Equal(expectedArray, actualArray);
                actualArray.Should().BeEquivalentTo(expectedArray);
            }
        }

        public class RearrangElements
        {
            [Fact]
            public void Should_rearrang_elements_correctly_1()
            {
                var expectedArray = new[] { 2, 1, 4, 3, 6, 5, 8, 7 };
                var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                ArrayHelpers.RearrangElements(array);
                ref var actualArray = ref array;
                //Assert.Equal(expectedArray, actualArray);
                actualArray.Should().BeEquivalentTo(expectedArray);
            }

            [Fact]
            public void Should_rearrang_elements_correctly_2()
            {
                var expectedArray = new[] { -6, 5, 7, 8, 21, 74 };
                var array = new[] { 5, -6, 8, 7, 74, 21 };
                ArrayHelpers.RearrangElements(array);
                ref var actualArray = ref array;
                //Assert.Equal(expectedArray, actualArray);
                actualArray.Should().BeEquivalentTo(expectedArray);
            }
        }

        public class ReplaceTwoDigit
        {
            [Fact]
            public void Should_replace_two_digit_elements_correctly()
            {
                var expectedArray = new[] { 112, 1111, 995, 1111, 1, 1111, 1111};
                var array = new[] { 112, -10, 995, 55, 1, 37, 99 };
                var number = 1111;
                ArrayHelpers.ReplaceTwoDigit(array, number);
                ref var actualArray = ref array;
                //Assert.Equal(expectedArray, actualArray);
                actualArray.Should().BeEquivalentTo(expectedArray);
            }

            [Fact]
            public void Should_replace_two_digit_elements_correctly_when_all_two_digit_numbers ()
            {
                var expectedArray = new[] { 1111, 1111, 1111, 1111, 1111, 1111, 1111 };
                var array = new[] { -99, 10, 25, 88, 17, 74, 42 };
                var number = 1111;
                ArrayHelpers.ReplaceTwoDigit(array, number);
                ref var actualArray = ref array;
                //Assert.Equal(expectedArray, actualArray);
                actualArray.Should().BeEquivalentTo(expectedArray);
            }
        }
    }
}
