namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the ValidParenthesis problem.
    /// </summary>
    public static class ValidParenthesis
    {
        /// <summary>
        /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.<br/><br/>
        ///An input string is valid if:
        ///Open brackets must be closed by the same type of brackets.<br/>
        ///Open brackets must be closed in the correct order.<br/>
        ///Every close bracket has a corresponding open bracket of the same type.<br/><br/>
        /// Example 1:
        ///Input: s = "()"
        ///Output: true<br/>
        ///Example 2:
        ///Input: s = "()[]{}"
        ///Output: true<br/>
        ///Example 3:
        ///Input: s = "(]"
        ///Output: false<br/><br/>
        ///Constraints:<br/>
        ///1 &lt;= s.length &lt;= 104
        ///s consists of parentheses only '()[]{}'.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>True if the string is valid</returns>
        public static bool SolveValidParenthesis(string s)
        {
            var stack = new Stack<char>();
            var openingTags = new List<char> { '(', '{', '[' };

            foreach (var tag in s)
            {
                if (openingTags.Contains(tag))
                {
                    stack.Push(tag);
                }
                else
                {
                    if (stack.TryPeek(out var topTag) && (tag == ')' && topTag == '(' || tag == '}' && topTag == '{' || tag == ']' && topTag == '['))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return !stack.Any();
        }
    }
}
