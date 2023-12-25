namespace LeetCodeCSharp.Medium
{
    /// <summary>
    /// This is the solution for the LongestPalindromicSubstring problem.
    /// </summary>
    /// 
    public static class LongestPalindromicSubstring
    {
        /// <summary>
        /// Given a string s, return the longest palindromic substring in s.<br/><br/>
        /// Example 1:<br/>
        /// Input: s = "babad"<br/>
        /// Output: "bab"<br/>
        /// Explanation: "aba" is also a valid answer.<br/><br/>
        /// Example 2:<br/>
        /// Input: s = "cbbd"<br/>
        /// Output: "bb"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string SolveLongestPalindromicSubstring(string s)
        {
            if (s is null || s.Length < 1) return "";

            var start = 0;
            var end = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var len1 = ExpandAroundCenter(s, i, i);
                var len2 = ExpandAroundCenter(s, i, i + 1);
                var len = Math.Max(len1, len2);

                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }

            return s.Substring(start, end - start + 1);
        }

        private static int ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left].Equals(s[right]))
            {
                left--;
                right++;
            }

            return right - left - 1;
        }
    }
}
