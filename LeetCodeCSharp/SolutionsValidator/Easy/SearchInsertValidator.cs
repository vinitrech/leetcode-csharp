using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class SearchInsertValidator
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
        public void OnSuccess_Should_Find_Correct_Answer_For_SearchInsert(int[] nums, int target, int expectedResult)
        {
            //Arrange+Act
            var result = SearchInsert.SolveSearchInsert(nums, target);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}