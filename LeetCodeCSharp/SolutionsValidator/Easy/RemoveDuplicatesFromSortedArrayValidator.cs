using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class RemoveDuplicatesFromSortedArrayValidator
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        public void OnSuccess_Should_Find_Correct_Answer_For_RemoveDuplicatesFromSortedArrayValidator(int[] nums, int expectedOutput)
        {
            //Arrange+Act
            var result = RemoveDuplicatesFromSortedArray.SolveRemoveDuplicatesFromSortedArray(nums);

            //Assert
            result.Should().Be(expectedOutput);
        }
    }
}