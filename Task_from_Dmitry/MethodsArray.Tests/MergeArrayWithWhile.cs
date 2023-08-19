using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MethodsArray.Tests
{
    public class MergeArrayWithWhile
    {
        [Fact]
        public void Should_merge_array_correctly_when_two_array_positive()
        {
            var expectedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var array1 = new int[] { 1, 2, 3, 4, 5 };
            var array2 = new int[] { 6, 7, 8, 9, 10 };
            var array3 = Logics.MergeArrayWithWhile(array1, array2);
            array3.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_merge_array_correctly_when_arrays_similars()
        {
            var expectedArray = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
            var array1 = new int[] { 1, 2, 3, 4, 5 };
            var array2 = new int[] { 1, 2, 3, 4, 5 };
            var array3 = Logics.MergeArrayWithWhile(array1, array2);
            array3.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_merge_array_correctly_when_two_array_negative()
        {
            var expectedArray = new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1 };
            var array1 = new int[] { -1, -2, -3, -4, -5 };
            var array2 = new int[] { -6, -7, -8, -9, -10 };
            var array3 = Logics.MergeArrayWithWhile(array1, array2);
            array3.Should().BeEquivalentTo(expectedArray);
        }
    }
}
