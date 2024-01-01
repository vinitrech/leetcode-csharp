using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class SqrtValidator
    {
        [Theory]
        [InlineData(4, 2)]
        [InlineData(8, 2)]
        [InlineData(2147395600, 46340)]
        public void OnSuccess_Should_Find_Correct_Answer_For_Sqrt(int x, int expectedResult)
        {
            //Arrange+Act
            var result = Sqrt.SolveSqrt(x);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}