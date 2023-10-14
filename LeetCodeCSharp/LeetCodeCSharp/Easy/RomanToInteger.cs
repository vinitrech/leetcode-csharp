namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the RomanToInteger problem.
    /// </summary>
    public static class RomanToInteger
    {
        /// <summary>
        ///Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
        ///<br/><br/>
        ///Symbol Value
        ///I             1
        ///V             5
        ///X             10
        ///L             50
        ///C             100
        ///D             500
        ///M             1000
        ///For example, 2 is written as II in Roman numeral, just two ones added together. <br/>
        ///12 is written as XII, which is simply X + II.The number 27 is written as XXVII, which is XX + V + II.
        ///<br/><br/>
        ///Roman numerals are usually written largest to smallest from left to right.<br/> 
        ///However, the numeral for four is not IIII. Instead, the number four is written as IV.<br/>
        ///Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:
        ///<br/><br/>
        ///I can be placed before V (5) and X(10) to make 4 and 9. <br/>
        ///X can be placed before L(50) and C(100) to make 40 and 90. <br/>
        ///C can be placed before D(500) and M(1000) to make 400 and 900.<br/>
        ///Given a roman numeral, convert it to an integer.
        ///<br/><br/>
        ///Example 1:
        ///Input: s = "III"
        ///Output: 3
        ///Explanation: III = 3.
        ///<br/><br/>
        ///Example 2:
        ///Input: s = "LVIII"
        ///Output: 58
        ///Explanation: L = 50, V= 5, III = 3.
        ///<br/><br/>
        ///Example 3:
        ///Input: s = "MCMXCIV"
        ///Output: 1994
        ///Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
        ///<br/><br/>
        ///Constraints:
        ///<br/><br/>
        ///1 &lt;= s.length &lt;= 15
        ///s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
        ///It is guaranteed that s is a valid roman numeral in the range[1, 3999].
        /// </summary>
        /// <param name="s">roman number in string format</param>
        /// <returns>The integer representation of the roman number</returns>
        public static int RomanToIntegerSolution(string s)
        {
            var result = 0;
            Dictionary<char, int> romanIntValue = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (var i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && romanIntValue[s[i]] < romanIntValue[s[i + 1]])
                {
                    result -= romanIntValue[s[i]];
                }
                else
                {
                    result += romanIntValue[s[i]];
                }
            }

            return result;
        }
    }
}
