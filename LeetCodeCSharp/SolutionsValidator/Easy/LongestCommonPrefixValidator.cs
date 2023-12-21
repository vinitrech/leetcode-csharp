using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class LongestCommonPrefixValidator
    {
        [Theory]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        public void OnSuccess_Should_Find_Correct_Answer_For_LongestCommonPrefix(string[] strs, string expectedResult)
        {
            //Arrange+Act
            var result = LongestCommonPrefix.SolveLongestCommonPrefix(strs);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}