using FluentAssertions;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class MergeTwoSortedListsValidator
    {
        public static readonly IEnumerable<object[]> TestCases = new List<object[]>()
        {
            new object[] {
                new ListNode{
                    Val = 1,
                    Next = new ListNode
                    {
                        Val = 2,
                        Next = new ListNode
                        {
                            Val = 4,
                            Next = null
                        }
                    }
                },
                new ListNode{
                    Val = 1,
                    Next = new ListNode
                    {
                        Val = 3,
                        Next = new ListNode
                        {
                            Val = 4,
                            Next = null
                        }
                    }
                },
                new ListNode
                {
                    Val = 1,
                    Next = new ListNode
                    {
                        Val= 1,
                        Next = new ListNode
                        {
                            Val = 2,
                            Next = new ListNode
                            {
                                Val = 3,
                                Next = new ListNode
                                {
                                    Val = 4,
                                    Next = new ListNode
                                    {
                                        Val = 4,
                                        Next = null
                                    }
                                }
                            }
                        }
                    }
                }
            },
            new object[] {
                new ListNode(),
                new ListNode(),
                new ListNode()
            },
            new object[] {
                new ListNode(),
                new ListNode
                {
                    Val = 0,
                    Next = null
                },
                new ListNode
                {
                    Val = 0
                }
            },
             new object[] {
                new ListNode
                {
                    Val = 2,
                    Next = null
                },
                new ListNode
                {
                    Val = 1,
                    Next = null
                },
                new ListNode
                {
                    Val = 1,
                    Next = null
                }
            }
        };

        [Theory]
        [MemberData(nameof(TestCases))]
        public void OnSuccess_Should_Find_Correct_Answer_For_MergeTwoSortedLists(ListNode list1, ListNode list2, ListNode expectedResult)
        {
            //Arrange
            AssertionOptions.FormattingOptions.MaxDepth = 100;

            //Act
            var result = MergeTwoSortedLists.SolveMergeTwoSortedLists(list1, list2);
            var currentValue = result;
            var currentExpectedResultValue = expectedResult;

            //Assert
            currentValue?.Val.Should().Be(currentExpectedResultValue?.Val);
        }
    }
}