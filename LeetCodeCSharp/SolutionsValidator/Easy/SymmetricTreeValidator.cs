using FluentAssertions;
using LeetCodeCSharp.DTOs;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class SymmetricTreeValidator
    {
        [Theory]
        [MemberData(nameof(SetupSymmetricTreeUseCases))]
        public void OnSuccess_Should_Find_Correct_Answer_For_SymmetricTree(TreeNode root, bool expectedOutput)
        {
            //Arrange+Act
            var result = SymmetricTree.SolveSymmetricTree(root);

            //Assert
            result.Should().Be(expectedOutput);
        }

        public static IEnumerable<object[]> SetupSymmetricTreeUseCases()
        {
            yield return new object[]
            {
                new TreeNode
                {
                    Val = 1,
                    Left = new TreeNode
                    {
                        Val = 2,
                        Left = new TreeNode
                        {
                            Val = 3
                        },
                        Right = new TreeNode
                        {
                            Val = 4
                        }
                    },
                    Right = new TreeNode
                    {
                        Val = 2,
                        Left = new TreeNode
                        {
                            Val = 4
                        },
                        Right = new TreeNode
                        {
                            Val = 3
                        }
                    },
                },
                true
            };

            yield return new object[]
            {
                new TreeNode
                {
                    Val = 1,
                    Left = new TreeNode
                    {
                        Val = 2,
                        Right = new TreeNode
                        {
                            Val = 3
                        }
                    },
                    Right = new TreeNode
                    {
                        Val = 2,
                        Right = new TreeNode
                        {
                            Val = 3
                        }
                    },
                },
                false
            };
        }
    }
}