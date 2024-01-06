using FluentAssertions;
using LeetCodeCSharp.DTOs;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class BinaryTreeInorderTraversalValidator
    {
        [Theory]
        [MemberData(nameof(SetupBinaryTreeInorderTraversalUseCases))]
        public void OnSuccess_Should_Find_Correct_Answer_For_AddBinary(TreeNode root, IList<int> expectedOutput)
        {
            //Arrange+Act
            var result = BinaryTreeInorderTraversal.SolveBinaryTreeInorderTraversal(root);

            //Assert
            result.Should().ContainInOrder(expectedOutput);
        }

        public static IEnumerable<object[]> SetupBinaryTreeInorderTraversalUseCases()
        {
            yield return new object[]
            {
                new TreeNode
                {
                    Val = 1,
                    Right = new TreeNode
                    {
                        Val = 2,
                        Right = new TreeNode
                        {
                            Val = 3
                        }
                    }
                },
                new List<int>{1,2,3}
            };

            yield return new object[]
            {
                new TreeNode(),
                new List<int>{}
            };

            yield return new object[]
            {
                new TreeNode(1),
                new List<int>{1}
            };
        }
    }
}