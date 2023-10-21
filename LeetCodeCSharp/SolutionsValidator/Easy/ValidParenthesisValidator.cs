using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class ValidParenthesisValidator
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("]", false)]
        public void OnSuccess_Should_Find_Correct_Answer_For_ValidParenthesis(string input, bool expectedResult)
        {
            //Arrange+Act
            var result = ValidParenthesis.ValidParenthesisSolution(input);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}