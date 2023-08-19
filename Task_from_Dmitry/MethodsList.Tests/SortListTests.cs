using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MethodsList.Tests
{
    public class SortListTests
    {
        [Fact]
        public void Should_sort_list_correctly()
        {
            var expectedList = new List<int> { -4, 0, 1, 2, 5, 6, 8 };
            var list = new List<int> { 2, 5, 6, 8, 1, -4, 0 };
            Logics.SortList(list);
            list.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_sort_list_for_second_variant_correctly()
        {
            var expectedList = new List<int> { -10, -9, -8, -7, -6, -5, -4 };
            var list = new List<int> { -4, -5, -6, -7, -8, -9, -10 };
            Logics.SortList(list);
            list.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_sort_list_for_third_variant_correctly()
        {
            var expectedList = new List<int> { -5, 0, 0, 2, 2, 3 };
            var list = new List<int> { 0, 0, -5, 2, 3, 2 };
            Logics.SortList(list);
            list.Should().BeEquivalentTo(expectedList);
        }
    }
}
