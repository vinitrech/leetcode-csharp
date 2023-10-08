namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the TwoSum problem.
    /// </summary>
    public static class TwoSum
    {
        /// <summary>
        ///Given an array of integers numbers and an integer target, return indices of the two numbers such that they add up to target.
        ///<br/>You may assume that each input would have exactly one solution, and you may not use the same element twice.
        ///<br/>You can return the answer in any order.
        ///<br/><br/>
        ///Example 1:
        ///Input: nums = [2, 7, 11, 15], target = 9
        ///Output: [0,1]
        ///Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        ///<br/><br/>
        ///Example 2:
        ///Input: nums = [3, 2, 4], target = 6
        ///Output: [1,2]
        ///<br/><br/>
        ///Example 3:
        ///Input: nums = [3, 3], target = 6
        ///Output: [0,1]
        ///<br/><br/>
        ///Constraints:
        ///2 &lt;= nums.length &lt;= 104
        ///-109 &lt;= nums[i] &lt;= 109
        ///-109 &lt;= target &lt;= 109
        ///<br/>Only one valid answer exists.
        ///<br/><br/>
        ///Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
        /// </summary>
        /// <param name="nums">Array of integers to search</param>
        /// <param name="target">Expected sum result</param>
        /// <returns>An array containing the indexes of the numbers that result in the expected sum</returns>
        public static int[] TwoSumSolution(int[] nums, int target)
        {
            var checkedValues = new Dictionary<int, int>();
            var currentIndex = 0;

            foreach (var number in nums)
            {
                var requiredValue = target - number;

                if (checkedValues.ContainsKey(requiredValue) && currentIndex != checkedValues[requiredValue])
                {
                    return new int[] { checkedValues[requiredValue], currentIndex };
                }

                _ = checkedValues.TryAdd(number, currentIndex++);
            }

            return Array.Empty<int>();
        }
    }
}
