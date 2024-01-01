namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the Sqrt problem.
    /// </summary>
    /// 

    public static class Sqrt
    {
        /// <summary>
        ///Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.<br/>
        ///You must not use any built-in exponent function or operator.<br/>
        ///For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.<br/><br/>
        /// Example 1:<br/>
        ///Input: x = 4<br/>
        ///Output: 2<br/>
        ///Explanation: The square root of 4 is 2, so we return 2.<br/><br/>
        ///Example 2:<br/>
        ///Input: x = 8<br/>
        ///Output: 2<br/>
        ///Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.<br/><br/>
        ///Constraints:<br/>
        ///0 &lt;= x &lt;= 231 - 1
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int SolveSqrt(int x)
        {
            long result = 0;

            for (long root = 0; root * root <= x; root++)
            {
                result = root;
            }

            return Convert.ToInt32(result);
        }
    }
}
