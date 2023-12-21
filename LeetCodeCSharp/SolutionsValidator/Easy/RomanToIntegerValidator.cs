using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class RomanToIntegerValidator
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void OnSuccess_Should_Find_Correct_Answer_For_RomanToInteger(string romanNumber, int expectedInteger)
        {
            //Arrange+Act
            var result = RomanToInteger.SolveRomanToInteger(romanNumber);

            //Assert
            result.Should().Be(expectedInteger);
        }
    }
}