using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class LengthOfLastWordValidator
    {
        [Theory]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
        [InlineData("a ", 1)]
        [InlineData("a", 1)]
        [InlineData(" a", 1)]
        [InlineData("day    ", 3)]
        public void OnSuccess_Should_Find_Correct_Answer_For_LengthOfLastWord(string s, int expectedResult)
        {
            //Arrange+Act
            var result = LengthOfLastWord.SolveLengthOfLastWord(s);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}