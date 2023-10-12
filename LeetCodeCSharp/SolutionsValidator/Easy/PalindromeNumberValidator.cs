using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class PalindromeNumberValidator
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        public void OnSuccess_Should_Find_Correct_Answer_For_PalindromeNumber(int input, bool result)
        {
            //Arrange+Act
            var isPalindrome = PalindromeNumber.PalindromeNumberSolution(input);

            //Assert
            isPalindrome.Should().Be(result);
        }
    }
}