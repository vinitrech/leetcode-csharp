namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the MergeSortedArray problem.
    /// </summary>
    /// 

    public static class MergeSortedArray
    {
        /// <summary>
        ///You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n,<br/>
        ///representing the number of elements in nums1 and nums2 respectively.<br/><br/>
        ///Merge nums1 and nums2 into a single array sorted in non-decreasing order.<br/>
        ///The final sorted array should not be returned by the function, but instead be stored inside the array nums1.<br/><br/>
        ///To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged,<br/>
        ///and the last n elements are set to 0 and should be ignored. nums2 has a length of n.<br/><br/>
        ///Example 1:<br/>
        ///Input: nums1 = [1, 2, 3, 0, 0, 0], m = 3, nums2 = [2, 5, 6], n = 3<br/>
        ///Output: [1,2,2,3,5,6]<br/>
        ///Explanation: The arrays we are merging are [1,2,3] and[2, 5, 6].<br/>
        ///The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.<br/><br/>
        ///Example 2:<br/>
        ///Input: nums1 = [1], m = 1, nums2 = [], n = 0<br/>
        ///Output: [1]<br/>
        ///Explanation: The arrays we are merging are [1] and[].<br/>
        ///The result of the merge is [1].<br/><br/>
        ///Example 3:<br/>
        ///Input: nums1 = [0], m = 0, nums2 = [1], n = 1<br/>
        ///Output: [1]<br/>
        ///Explanation: The arrays we are merging are [] and[1].<br/>
        ///The result of the merge is [1].<br/>
        ///Note that because m = 0, there are no elements in nums1.The 0 is only there to ensure the merge result can fit in nums1.<br/><br/>
        ///Constraints:<br/>
        ///nums1.length == m + n<br/>
        ///nums2.length == n<br/>
        ///0 &lt;= m, n &lt;= 200<br/>
        ///1 &lt;= m + n &lt;= 200<br/>
        ///-109 &lt;= nums1[i], nums2[j] &lt;= 109
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public static void SolveMergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {

        }
    }
}
