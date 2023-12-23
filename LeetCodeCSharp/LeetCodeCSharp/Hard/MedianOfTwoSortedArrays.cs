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
            var merged = new List<int>();
            var x = 0;
            var y = 0;

            while (x < nums1.Length && y < nums2.Length)
            {
                if (nums1[x] < nums2[y])
                {
                    merged.Add(nums1[x++]);
                }
                else
                {
                    merged.Add(nums2[y++]);
                }
            }

            if (x < nums1.Length) merged.AddRange(nums1[x..]);
            if (y < nums2.Length) merged.AddRange(nums2[y..]);

            var middleElement = merged.Count / 2;

            if (merged.Count % 2 == 0)
            {
                return (merged[middleElement - 1] + merged[middleElement]) / 2.0;
            }
            else
            {
                return merged[middleElement];
            }
        }
    }
}
