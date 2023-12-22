namespace LeetCodeCSharp.Medium
{
    /// <summary>
    /// This is the solution for the LengthOfLongestSubstring problem.
    /// </summary>
    /// 
    public static class LengthOfLongestSubstring
    {
        /// <summary>
        /// Given a string s, find the length of the longest substring without repeating characters.<br/><br/>
        /// Example 1:<br/>
        /// Input: s = "abcabcbb"<br/>
        /// Output: 3<br/>
        /// Explanation: The answer is "abc", with the length of 3.<br/><br/>
        /// Example 2:<br/>
        /// Input: s = "bbbbb"<br/>
        /// Output: 1<br/>
        /// Explanation: The answer is "b", with the length of 1.<br/><br/>
        /// Example 3:<br/>
        /// Input: s = "pwwkew"<br/>
        /// Output: 3<br/>
        /// Explanation: The answer is "wke", with the length of 3.<br/><br/>
        /// Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int SolveLengthOfLongestSubstring(string s)
        {
            var biggestSubstringLength = 0;
            var charDictionary = new List<char>();

            if (s.Length == 0)
            {
                return 0;
            }

            for (var i = 0; i < s.Length; i++)
            {
                for (var j = i; j < s.Length; j++)
                {
                    if (charDictionary.Contains(s[j]))
                    {
                        break;
                    }

                    charDictionary.Add(s[j]);
                    biggestSubstringLength = charDictionary.Count > biggestSubstringLength ? charDictionary.Count : biggestSubstringLength;
                }

                charDictionary.Clear();
            }

            return biggestSubstringLength;
        }
    }
}
