using FluentAssertions;
using LeetCodeCSharp.DTOs;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class SameTreeValidator
    {
        [Theory]
        [MemberData(nameof(SetupSolveSameTreeUseCases))]
        public void OnSuccess_Should_Find_Correct_Answer_For_SameTree(TreeNode? p, TreeNode? q, bool expectedOutput)
        {
            //Arrange+Act
            var result = SameTree.SolveSameTree(p, q);

            //Assert
            result.Should().Be(expectedOutput);
        }

        public static IEnumerable<object[]> SetupSolveSameTreeUseCases()
        {
            yield return new object[]
            {
                new TreeNode
                {
                    Val = 1,
                    Left = new TreeNode
                    {
                        Val = 2
                    },
                    Right = new TreeNode
                    {
                        Val = 3
                    }
                },
                new TreeNode
                {
                    Val = 1,
                    Left = new TreeNode
                    {
                        Val = 2
                    },
                    Right = new TreeNode
                    {
                        Val = 3
                    }
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
                        Val = 2
                    }
                },
                new TreeNode
                {
                    Val = 1,
                    Right = new TreeNode
                    {
                        Val = 3
                    }
                },
                false
            };

            yield return new object[]
            {
                new TreeNode
                {
                    Val = 1,
                    Left = new TreeNode
                    {
                        Val = 2
                    },
                    Right = new TreeNode
                    {
                        Val = 1
                    }
                },
                new TreeNode
                {
                    Val = 1,
                    Left = new TreeNode
                    {
                        Val = 1
                    },
                    Right = new TreeNode
                    {
                        Val = 2
                    }
                },
                false
            };
        }
    }
}