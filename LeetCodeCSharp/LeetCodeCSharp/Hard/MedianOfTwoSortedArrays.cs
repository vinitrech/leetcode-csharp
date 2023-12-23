namespace LeetCodeCSharp.Medium
{
    /// <summary>
    /// This is the solution for the AddTwoNumbers problem.
    /// </summary>
    /// 

    public static class MedianOfTwoSortedArrays
    {
        /// <summary>
        /// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.<br/>
        ///The overall run time complexity should be O(log (m+n)).<br/><br/>
        /// Example 1:<br/>
        ///Input: nums1 = [1,3], nums2 = [2]<br/>
        ///Output: 2.00000<br/>
        ///Explanation: merged array = [1, 2, 3] and median is 2.<br/><br/>
        ///Example 2:<br/>
        ///Input: nums1 = [1,2], nums2 = [3,4]<br/>
        ///Output: 2.50000<br/>
        ///Explanation: merged array = [1, 2, 3, 4] and median is (2 + 3) / 2 = 2.5.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static double SolveMedianOfTwoSortedArrays(int[] nums1, int[] nums2)
        {
            var median = 0.0f;
            int[] concat = [.. nums1, .. nums2];
            Array.Sort(concat);

            if (concat.Length % 2 == 0)
            {
                median = (concat[concat.Length / 2] + concat[(concat.Length / 2) - 1]) / 2.0f;
            }
            else
            {
                median = concat[concat.Length / 2];
            }

            return median;
        }
    }
}
