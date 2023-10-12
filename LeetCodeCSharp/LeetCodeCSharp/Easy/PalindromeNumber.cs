namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the TwoSum problem.
    /// </summary>
    public static class PalindromeNumber
    {
        /// <summary>
        ///Given an integer x, return true if x is a palindrome, and false otherwise.
        ///<br/><br/>
        ///Example 1:
        ///Input: x = 121
        ///Output: true
        ///Explanation: 121 reads as 121 from left to right and from right to left.
        ///<br/><br/>
        ///Example 2:
        ///Input: x = -121
        ///Output: false
        ///Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
        ///<br/><br/>
        ///Example 3:
        ///Input: x = 10
        ///Output: false
        ///Explanation: Reads 01 from right to left.Therefore it is not a palindrome.
        ///<br/><br/>
        ///Constraints:
        ///-231 &lt;= x &lt;= 231 - 1
        ///Follow up: Could you solve it without converting the integer to a string?
        /// </summary>
        /// <param name="number">Integer to check</param>
        /// <returns>True if number is a palindrome</returns>
        public static bool PalindromeNumberSolution(int number)
        {
            var x = number;
            var y = 0;

            while (x > 0)
            {
                y = (y * 10) + (x % 10);
                x /= 10;
            }

            return y == number;
        }
    }
}
