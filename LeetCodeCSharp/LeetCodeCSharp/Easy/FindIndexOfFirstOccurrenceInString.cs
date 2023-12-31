namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the FindIndexOfFirstOccurrenceInString problem.
    /// </summary>
    /// 

    public static class FindIndexOfFirstOccurrenceInString
    {
        /// <summary>
        ///Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.<br/><br/>
        ///Example 1:<br/>
        ///Input: haystack = "sadbutsad", needle = "sad"<br/>
        ///Output: 0<br/>
        ///Explanation: "sad" occurs at index 0 and 6.<br/>
        ///The first occurrence is at index 0, so we return 0.<br/><br/>
        ///Example 2:<br/>
        ///Input: haystack = "leetcode", needle = "leeto"<br/>
        ///Output: -1<br/>
        ///Explanation: "leeto" did not occur in "leetcode", so we return -1.<br/><br/>
        ///Constraints:<br/>
        ///1 &lt;= haystack.length, needle.length &lt;= 104<br/>
        ///haystack and needle consist of only lowercase English characters.
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public static int SolveFindIndexOfFirstOccurrenceInString(string haystack, string needle)
        {
            if (needle.Length > haystack.Length) return -1;

            var startIdex = 0;
            var endIndex = needle.Length;

            while (endIndex <= haystack.Length)
            {
                if (haystack[startIdex..endIndex].Equals(needle)) return startIdex;

                startIdex++;
                endIndex++;
            }

            return -1;
        }
    }
}
