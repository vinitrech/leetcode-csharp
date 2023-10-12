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
            var digits = new List<int>();

            if (number < 0)
            {
                return false;
            }

            while (number > 0)
            {
                digits.Add(number % 10);
                number /= 10;
            }

            for (var x = 0; x < digits.Count; x++)
            {
                var counterpart = digits.Count - x - 1;

                if (digits[x] != digits[counterpart])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
