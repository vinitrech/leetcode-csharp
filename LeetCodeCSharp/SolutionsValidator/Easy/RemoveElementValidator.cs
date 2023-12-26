using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class RemoveElementValidator
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
        //[InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        public void OnSuccess_Should_Find_Correct_Answer_For_RemoveElement(int[] nums, int val, int expectedResult)
        {
            //Arrange+Act
            var result = RemoveElement.SolveRemoveElement(nums, val);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}