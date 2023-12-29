namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the PlusOne problem.
    /// </summary>
    /// 

    public static class PlusOne
    {
        /// <summary>
        /// You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order.<br/>
        /// The large integer does not contain any leading 0's.<br/>
        /// Increment the large integer by one and return the resulting array of digits.<br/><br/>
        /// Example 1:<br/>
        ///Input: digits = [1,2,3]<br/>
        ///Output: [1,2,4]<br/>
        ///Explanation: The array represents the integer 123.<br/>
        ///Incrementing by one gives 123 + 1 = 124.<br/>
        ///Thus, the result should be[1, 2, 4].<br/><br/>
        ///Example 2:<br/>
        ///Input: digits = [4,3,2,1]<br/>
        ///Output: [4,3,2,2]<br/>
        ///Explanation: The array represents the integer 4321.<br/>
        ///Incrementing by one gives 4321 + 1 = 4322.<br/>
        ///Thus, the result should be[4, 3, 2, 2].<br/><br/>
        ///Example 3:<br/>
        ///Input: digits = [9]<br/>
        ///Output: [1,0]<br/>
        ///Explanation: The array represents the integer 9.<br/>
        ///Incrementing by one gives 9 + 1 = 10.<br/>
        ///Thus, the result should be[1, 0].<br/><br/>
        ///Constraints:<br/>
        ///1 &lt;= digits.length &lt;= 100<br/>
        ///0 &lt;= digits[i] &lt;= 9<br/>
        ///digits does not contain any leading 0's.
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static int[] SolvePlusOne(int[] digits)
        {
            var newNumber = Array.Empty<int>();
            var amountToSum = 1;
            var number = 0;

            for (var index = digits.Length - 1; index >= 0; index--)
            {
                number = digits[index] + amountToSum;
                amountToSum = number / 10;
                newNumber = [number % 10, .. newNumber];
            }

            if (amountToSum > 0)
            {
                newNumber = [amountToSum, .. newNumber];
            }

            return newNumber;
        }
    }
}
