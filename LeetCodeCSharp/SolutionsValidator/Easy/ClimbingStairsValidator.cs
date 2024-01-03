using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class ClimbingStairsValidator
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 5)]
        [InlineData(5, 8)]
        [InlineData(6, 13)]
        public void OnSuccess_Should_Find_Correct_Answer_For_ClimbingStairs(int n, int expectedResult)
        {
            //Arrange+Act
            var result = ClimbingStairs.SolveClimbingStairs(n);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}