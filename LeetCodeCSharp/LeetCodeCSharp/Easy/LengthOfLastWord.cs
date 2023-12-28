namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the LengthOfLastWord problem.
    /// </summary>
    /// 

    public static class LengthOfLastWord
    {
        /// <summary>
        /// Given a string s consisting of words and spaces, return the length of the last word in the string.<br/>
        ///A word is a maximal substring consisting of non-space characters only.<br/><br/>
        ///Example 1:<br/>
        ///Input: s = "Hello World"<br/>
        ///Output: 5<br/>
        ///Explanation: The last word is "World" with length 5.<br/><br/>
        ///Example 2:<br/>
        ///Input: s = "   fly me   to   the moon  "<br/>
        ///Output: 4<br/>
        ///Explanation: The last word is "moon" with length 4.<br/><br/>
        ///Example 3:<br/>
        ///Input: s = "luffy is still joyboy"<br/>
        ///Output: 6<br/>
        ///Explanation: The last word is "joyboy" with length 6.<br/><br/>
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int SolveLengthOfLastWord(string s)
        {
            var wordFound = false;
            var length = 0;

            for (var index = s.Length - 1; index >= 0; index--)
            {
                if (s[index].Equals(' ') && wordFound)
                {
                    return length;
                }

                if (!s[index].Equals(' '))
                {
                    wordFound = true;
                    length++;
                }
            }

            return length;
        }
    }
}
