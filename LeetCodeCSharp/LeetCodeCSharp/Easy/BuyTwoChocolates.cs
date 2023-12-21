namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the BuyTwoChocolates problem.
    /// </summary>
    public static class BuyTwoChocolates
    {
        /// <summary>
        ///You are given an integer array prices representing the prices of various chocolates in a store.<br/> You are also given a single integer money, which represents your initial amount of money.<br/>
        ///You must buy exactly two chocolates in such a way that you still have some non-negative leftover money. You would like to minimize the sum of the prices of the two chocolates you buy.<br/>
        ///Return the amount of money you will have leftover after buying the two chocolates.If there is no way for you to buy two chocolates without ending up in debt, return money.<br/>
        ///Note that the leftover must be non-negative.<br/><br/>
        ///Example 1:<br/>
        ///Input: prices = [1,2,2], money = 3<br/>
        ///Output: 0<br/>
        ///Explanation: Purchase the chocolates priced at 1 and 2 units respectively.You will have 3 - 3 = 0 units of money afterwards. Thus, we return 0.<br/><br/>
        /// Example 2:<br/>
        /// Input: prices = [3, 2, 3], money = 3<br/>
        /// Output: 3<br/>
        ///Explanation: You cannot buy 2 chocolates without going in debt, so we return 3.
        /// </summary>
        /// <param name="prices"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public static int SolveBuyTwoChocolates(int[] prices, int money)
        {
            Array.Sort(prices);
            var cheapestItemsBuy = prices[0] + prices[1];
            var remainingMoney = money - cheapestItemsBuy;

            if (cheapestItemsBuy > money || remainingMoney < 0)
            {
                return money;
            }

            return remainingMoney;
        }
    }
}
