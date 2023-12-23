using FluentAssertions;
using LeetCodeCSharp.Medium;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class MedianOfTwoSortedArraysValidator
    {
        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2.0)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        [InlineData(new int[] { 1, 3 }, new int[] { 2, 7 }, 2.5)]
        public void OnSuccess_Should_Find_Correct_Answer_For_MedianOfTwoSortedArrays(int[] nums1, int[] nums2, double expectedOutput)
        {
            //Arrange+Act
            var result = MedianOfTwoSortedArrays.SolveMedianOfTwoSortedArrays(nums1, nums2);

            //Assert
            result.Should().Be(expectedOutput);
        }
    }
}