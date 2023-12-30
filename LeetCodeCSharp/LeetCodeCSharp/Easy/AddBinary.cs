using System.Text;

namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the AddBinary problem.
    /// </summary>
    /// 

    public static class AddBinary
    {
        /// <summary>
        /// Given two binary strings a and b, return their sum as a binary string.<br/><br/>
        /// Example 1:<br/>
        ///Input: a = "11", b = "1"<br/>
        ///Output: "100"<br/><br/>
        ///Example 2:<br/>
        ///Input: a = "1010", b = "1011"<br/>
        ///Output: "10101"<br/><br/>
        ///Constraints:<br/>
        ///1 &lt;= a.length, b.length &lt;= 104<br/>
        ///a and b consist only of '0' or '1' characters.<br/>
        ///Each string does not contain leading zeros except for the zero itself.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string SolveAddBinary(string a, string b)
        {
            var sum = new StringBuilder();
            var (i, j, carry) = (a.Length - 1, b.Length - 1, 0);

            while (i >= 0 || j >= 0 || carry > 0)
            {
                var (firstDigit, secondDigit) = (i >= 0 ? a[i--] - '0' : 0, j >= 0 ? b[j--] - '0' : 0);
                var sumDigit = firstDigit + secondDigit + carry;

                carry = sumDigit / 2;
                sum.Insert(0, sumDigit % 2);
            }

            return sum.ToString();
        }
    }
}
