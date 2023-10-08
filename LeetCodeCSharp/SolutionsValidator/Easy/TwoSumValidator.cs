using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class TwoSumValidator
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void OnSuccess_Should_Find_Correct_Answer_For_TwoSum(int[] input, int target, int[] solution)
        {
            //Arrange+Act
            var result = TwoSum.TwoSumSolution(input, target);

            //Assert
            result.Should().HaveCount(solution.Length);
            result.Should().ContainInOrder(solution);
        }
    }
}