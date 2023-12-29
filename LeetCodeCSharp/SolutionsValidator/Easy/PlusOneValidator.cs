using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class PlusOneValidator
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
        [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
        public void OnSuccess_Should_Find_Correct_Answer_For_PlusOne(int[] digits, int[] expectedOutput)
        {
            //Arrange+Act
            var result = PlusOne.SolvePlusOne(digits);

            //Assert
            result.Should().BeEquivalentTo(expectedOutput);
        }
    }
}