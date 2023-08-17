using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace MethodsList.Tests
{
    public class MergeListTests
    {
        [Fact]
        public void Should_merge_list_correctly_when_two_lists_positive()
        {
            var expectedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var list1 = new List<int> { 1, 2, 3, 4, 5 };
            var list2 = new List<int> { 6, 7, 8, 9, 10 };
            var list3 = Logics.MergeList(list1, list2);
            list3.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_merge_list_correctly_when_lists_similars()
        {
            var expectedList = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
            var list1 = new List<int> { 1, 2, 3, 4, 5 };
            var list2 = new List<int> { 1, 2, 3, 4, 5 };
            var list3 = Logics.MergeList(list1, list2);
            list3.Should().BeEquivalentTo(expectedList);
        }

        [Fact]
        public void Should_merge_list_correctly_when_two_lists_negative()
        {
            var expectedList = new List<int> { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1 };
            var list1 = new List<int> { -1, -2, -3, -4, -5 };
            var list2 = new List<int> { -6, -7, -8, -9, -10 };
            var list3 = Logics.MergeList(list1, list2);
            list3.Should().BeEquivalentTo(expectedList);
        }
    }
}
