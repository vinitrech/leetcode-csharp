using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class BuyTwoChocolatesValidator
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 2 }, 3, 0)]
        [InlineData(new int[] { 3, 2, 3 }, 3, 3)]
        [InlineData(new int[] { 98, 54, 6, 34, 66, 63, 52, 39 }, 62, 22)]
        public void OnSuccess_Should_Find_Correct_Answer_For_BuyTwoChocolates(int[] prices, int money, int expectedResult)
        {
            //Arrange+Act
            var result = BuyTwoChocolates.BuyTwoChocolatesSolution(prices, money);

            //Assert
            result.Should().Be(expectedResult);
        }
    }
}