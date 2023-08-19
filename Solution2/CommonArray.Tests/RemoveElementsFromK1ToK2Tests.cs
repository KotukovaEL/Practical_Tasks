using FluentAssertions;
using Xunit;

namespace CommonArray.Tests
{
    public class RemoveElementsFromK1ToK2Tests
    {
        [Fact]
        public void Should_remove_elements_from_k1_to_k2_correctly()
        {
            var expectedArray = new[] { 1, 5, 6, 7 };
            var k1 = 1;
            var k2 = 3;
            var array = new[] { 1, 2, 3, 4, 5, 6, 7 };
            ArrayHelpers.RemoveElementsFromK1ToK2(ref array, k1, k2);
            array.Should().BeEquivalentTo(expectedArray);
        }

        [Fact]
        public void Should_remove_elements_from_k1_to_k2_correctly_when_first_element()
        {
            var expectedArray = new[] { 2, 3, 4, 5, 6, 7 };
            var k1 = 0;
            var k2 = 0;
            var array = new[] { 1, 2, 3, 4, 5, 6, 7 };
            ArrayHelpers.RemoveElementsFromK1ToK2(ref array, k1, k2);
            array.Should().BeEquivalentTo(expectedArray);
        }
    }
}
