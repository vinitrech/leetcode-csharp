using FluentAssertions;
using LeetCodeCSharp.DTOs;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class MaximumDepthOfBinaryTreeValidator
    {
        [Theory]
        [MemberData(nameof(SetupMaximumDepthOfBinaryTreeUseCases))]
        public void OnSuccess_Should_Find_Correct_Answer_For_MaximumDepthOfBinaryTree(TreeNode root, int expectedOutput)
        {
            //Arrange+Act
            var result = MaximumDepthOfBinaryTree.SolveMaximumDepthOfBinaryTree(root);

            //Assert
            result.Should().Be(expectedOutput);
        }

        public static IEnumerable<object[]> SetupMaximumDepthOfBinaryTreeUseCases()
        {
            yield return new object[]
            {
                new TreeNode
                {
                    Val = 3,
                    Left = new TreeNode
                    {
                        Val = 9
                    },
                    Right = new TreeNode
                    {
                        Val = 20,
                        Left = new TreeNode
                        {
                            Val = 15
                        },
                        Right = new TreeNode
                        {
                            Val = 7
                        }
                    }
                },
                3
            };

            yield return new object[]
            {
                new TreeNode
                {
                    Val = 1,
                    Right = new TreeNode
                    {
                        Val = 2
                    }
                },
                2
            };
        }
    }
}