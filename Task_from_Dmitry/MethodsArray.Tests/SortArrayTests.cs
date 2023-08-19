using FluentAssertions;
using Xunit;

namespace MethodsArray.Tests
{
    public class SortArrayTests
    {
        [Theory]
        [InlineData(new int[] { 2, 5, 6, 8, 1, -4, 0 }, new int[] { -4, 0, 1, 2, 5, 6, 8 })]
        [InlineData(new int[] { 0, 0, -5, 2, 3, 2 }, new int[] { -5, 0, 0, 2, 2, 3 })]
        [InlineData(new int[] { -4, -5, -6, -7, -8, -9, -10 }, new int[] { -10, -9, -8, -7, -6, -5, -4 })]
        public void Should_sort_array_correctly(int[] array, int[] expectedArray)
        {
            Logics.SortArray(array);
            array.Should().BeEquivalentTo(expectedArray);
        }
    }
}
