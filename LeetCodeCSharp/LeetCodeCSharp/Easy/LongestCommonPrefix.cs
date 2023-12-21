using System.Text;

namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the LongestCommonPrefix problem.
    /// </summary>
    public static class LongestCommonPrefix
    {
        /// <summary>
        ///Write a function to find the longest common prefix string amongst an array of strings.<br/>
        ///If there is no common prefix, return an empty string "".<br/><br/>///Example 1:
        ///Input: strs = ["flower", "flow", "flight"]<br/>
        ///Output: "fl"<br/><br/>
        ///Example 2:<br/>
        ///Input: strs = ["dog", "racecar", "car"]<br/>
        ///Output: ""<br/>
        ///Explanation: There is no common prefix among the input strings.<br/><br/>
        ///Constraints:<br/>
        ///1 &lt;= strs.length &lt;= 200<br/>
        ///0 &lt;= strs[i].length &lt;= 200<br/>
        ///strs[i] consists of only lowercase English letters.
        /// </summary>
        /// <param name="strs">strings to search</param>
        /// <returns>The longest common prefix or an empty string</returns>
        public static string SolveLongestCommonPrefix(string[] strs)
        {
            var prefix = new StringBuilder();
            var index = 0;

            while (index < strs[0].Length)
            {
                var letter = strs[0][index];

                if (Array.TrueForAll(strs, s => s.ElementAtOrDefault(index).Equals(letter)))
                {
                    prefix.Append(letter);
                }
                else
                {
                    return prefix.ToString();
                }

                index++;
            }

            return prefix.ToString();
        }
    }
}
