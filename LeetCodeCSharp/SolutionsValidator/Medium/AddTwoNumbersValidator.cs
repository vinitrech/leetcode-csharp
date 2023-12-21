using FluentAssertions;
using LeetCodeCSharp.DTOs;
using LeetCodeCSharp.Medium;
using Xunit;

namespace SolutionsValidator.Medium
{
    public class AddTwoNumbersValidator
    {
        [Theory]
        [MemberData(nameof(SetupAddTwoNumbersScenarios))]
        public void OnSuccess_Should_Find_Correct_Answer_For_AddTwoNumbers(ListNode l1, ListNode l2, ListNode expectedListNode)
        {
            //Arrange+Act
            var result = AddTwoNumbers.SolveAddTwoNumbers(l1, l2);

            //Assert
            result.Should().Be(expectedListNode);
        }

        public static IEnumerable<object[]?> SetupAddTwoNumbersScenarios()
        {
            yield return new object[]
            {
                new ListNode
                {
                    Val = 2,
                    Next = new ListNode
                    {
                        Val = 4,
                        Next = new ListNode
                        {
                            Val = 3
                        }
                    }
                },
                new ListNode
                {
                    Val = 5,
                    Next = new ListNode
                    {
                        Val = 6,
                        Next = new ListNode
                        {
                            Val = 4
                        }
                    }
                },
                new ListNode
                {
                    Val = 7,
                    Next = new ListNode
                    {
                        Val = 0,
                        Next = new ListNode
                        {
                            Val = 8
                        }
                    }
                }
            };

            yield return new object[]
            {
                new ListNode
                {
                    Val = 0
                },
                new ListNode
                {
                    Val = 0
                },
                new ListNode
                {
                    Val = 0
                }
            };

            yield return new object[]
            {
                new ListNode
                {
                    Val = 9,
                    Next = new ListNode
                    {
                        Val = 9,
                        Next = new ListNode
                        {
                            Val = 9,
                            Next = new ListNode
                            {
                                Val = 9,
                                Next = new ListNode
                                {
                                    Val = 9,
                                    Next = new ListNode
                                    {
                                        Val = 9,
                                        Next = new ListNode
                                        {
                                            Val = 9
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ListNode
                {
                    Val = 9,
                    Next = new ListNode
                    {
                        Val = 9,
                        Next = new ListNode
                        {
                            Val = 9,
                            Next = new ListNode
                            {
                                Val = 9
                            }
                        }
                    }
                },
                new ListNode
                {
                    Val = 8,
                    Next = new ListNode
                    {
                        Val = 9,
                        Next = new ListNode
                        {
                            Val = 9,
                            Next = new ListNode
                            {
                                Val = 9,
                                Next = new ListNode
                                {
                                    Val = 0,
                                    Next = new ListNode
                                    {
                                        Val = 0,
                                        Next = new ListNode
                                        {
                                            Val = 0,
                                            Next = new ListNode
                                            {
                                                Val = 1
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}