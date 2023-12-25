﻿namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the RemoveDuplicatesFromSortedArray problem.
    /// </summary>
    public static class RemoveDuplicatesFromSortedArray
    {
        /// <summary>
        /// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.<br/><br/>
        /// Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:<br/>
        /// Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.<br/>
        /// Return k.<br/>
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SolveRemoveDuplicatesFromSortedArray(int[] nums)
        {
            var uniqueNumberIndex = 0;

            for (var n = 0; n < nums.Length; n++)
            {
                if (nums[n] > nums[uniqueNumberIndex])
                {
                    nums[++uniqueNumberIndex] = nums[n];
                }
            }

            return uniqueNumberIndex + 1;
        }
    }
}
