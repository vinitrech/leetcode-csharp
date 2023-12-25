using FluentAssertions;
using LeetCodeCSharp.Medium;
using Xunit;

namespace SolutionsValidator.Medium
{
    public class LengthOfLongestSubstringValidator
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData(" ", 1)]
        [InlineData("au", 2)]
        [InlineData("dvdf", 3)]
        public void OnSuccess_Should_Find_Correct_Answer_For_LengthOfLongestSubstring(string s, int expectedOutput)
        {
            //Arrange+Act
            var result = LengthOfLongestSubstring.SolveLengthOfLongestSubstring(s);

            //Assert
            result.Should().Be(expectedOutput);
        }
    }
}