using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class FindIndexOfFirstOccurrenceInStringValidator
    {
        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto", -1)]
        [InlineData("a", "a", 0)]
        public void OnSuccess_Should_Find_Correct_Answer_For_FindIndexOfFirstOccurrenceInString(string haystack, string needle, int expectedResult)
        {
            //Arrange+Act
            var result = FindIndexOfFirstOccurrenceInString.SolveFindIndexOfFirstOccurrenceInString(haystack, needle);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}