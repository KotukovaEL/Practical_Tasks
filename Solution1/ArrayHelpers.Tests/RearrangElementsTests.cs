using FluentAssertions;
using Xunit;

namespace CommonArray.Tests
{
    public class RearrangElementsTests
    {
        [Fact]
        public void Should_rearrang_elements_correctly_1()
        {
            var expectedArray = new[] { 2, 1, 4, 3, 6, 5, 8, 7 };
            var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            ArrayHelpers.RearrangElements(array);
            //Assert.Equal(expectedArray, actualArray);
            array.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_rearrang_elements_correctly_2()
        {
            var expectedArray = new[] { -6, 5, 7, 8, 21, 74 };
            var array = new[] { 5, -6, 8, 7, 74, 21 };
            ArrayHelpers.RearrangElements(array);
            //Assert.Equal(expectedArray, actualArray);
            array.Should().BeEquivalentTo(expectedArray);
        }
    }
}
