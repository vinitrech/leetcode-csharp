namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the SearchInsert problem.
    /// </summary>
    /// 

    public static class SearchInsert
    {
        /// <summary>
        /// Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.<br/>
        /// You must write an algorithm with O(log n) runtime complexity.<br/><br/>
        /// Example 1:<br/>
        /// Input: nums = [1,3,5,6], target = 5<br/>
        /// Output: 2<br/><br/>
        /// Example 2:<br/>
        /// Input: nums = [1,3,5,6], target = 2<br/>
        /// Output: 1<br/><br/>
        /// Example 3:<br/>
        /// Input: nums = [1,3,5,6], target = 7<br/>
        /// Output: 4<br/><br/>
        /// Constraints:<br/>
        /// 1 &lt;= nums.length &lt;= 104<br/>
        /// -104 &lt;= nums[i] &lt;= 104<br/>
        /// nums contains distinct values sorted in ascending order.<br/>
        /// -104 &lt;= target &lt;= 104
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int SolveSearchInsert(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target) return i;
            }

            return nums.Length;
        }
    }
}
