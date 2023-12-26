namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the RemoveElement problem.
    /// </summary>
    public static class RemoveElement
    {
        /// <summary>
        /// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.The order of the elements may be changed.Then return the number of elements in nums which are not equal to val.<br/>
        /// Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:<br/>
        /// Change the array nums such that the first k elements of nums contain the elements which are not equal to val.The remaining elements of nums are not important as well as the size of nums.<br/>
        /// Return k.<br/><br/>
        /// Example 1:<br/>
        /// Input: nums = [3,2,2,3], val = 3<br/>
        /// Output: 2, nums = [2,2, _, _]<br/>
        /// Explanation: Your function should return k = 2, with the first two elements of nums being 2.<br/>
        /// It does not matter what you leave beyond the returned k(hence they are underscores).<br/><br/>
        /// Example 2:<br/>
        /// Input: nums = [0,1,2,2,3,0,4,2], val = 2<br/>
        /// Output: 5, nums = [0,1,4,0,3, _, _, _]<br/>
        /// Explanation: Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4.<br/>
        /// Note that the five elements can be returned in any order.<br/>
        /// It does not matter what you leave beyond the returned k (hence they are underscores).<br/><br/>
        /// Constraints:<br/>
        /// 0 &lt;= nums.length &lt;= 100<br/>
        /// 0 &lt;= nums[i] &lt;= 50<br/>
        /// 0 &lt;= val &lt;= 100
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>

        public static int SolveRemoveElement(int[] nums, int val)
        {
            var availableIndex = 0;

            for (var index = 0; index < nums.Length; index++)
            {
                if (nums[index] != val)
                {
                    nums[availableIndex++] = nums[index];
                }
            }

            return availableIndex;
        }
    }
}
