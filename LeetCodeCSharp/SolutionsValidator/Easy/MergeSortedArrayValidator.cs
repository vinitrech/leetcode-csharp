using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class MergeSortedArrayValidator
    {
        [Theory]
        [MemberData(nameof(SetupSolveMergeSortedArrayUseCases))]
        public void OnSuccess_Should_Find_Correct_Answer_For_MergeSortedArray(int[] nums1, int m, int[] nums2, int n, int[] expectedResult)
        {
            //Arrange+Act
            MergeSortedArray.SolveMergeSortedArray(nums1, m, nums2, n);

            //Assert
            nums1.Should().ContainInOrder(expectedResult);
        }

        public static IEnumerable<object[]> SetupSolveMergeSortedArrayUseCases()
        {
            yield return new object[]
            {
                    new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 }
            };

            yield return new object[]
            {
                    new int[] { 1 }, 1, Array.Empty<int>(), 0, new int[] { 1 }
            };

            yield return new object[]
            {
                new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 }
            };

            yield return new object[]
            {
                new int[] { 4,5,6,0,0,0 }, 3, new int[] { 1,2,3 }, 3, new int[] { 1,2,3,4,5,6 }
            };

            yield return new object[]
            {
                new int[] { 4,0,0,0,0,0 }, 1, new int[] { 1,2,3,5,6 }, 5, new int[] { 1,2,3,4,5,6 }
            };

            yield return new object[]
            {
                new int[] { 1,2,4,5,6,0 }, 5, new int[] { 3 }, 1, new int[] { 1,2,3,4,5,6 }
            };
        }
    }
}