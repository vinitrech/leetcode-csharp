using FluentAssertions;
using LeetCodeCSharp.DTOs;
using LeetCodeCSharp.Easy;
using Xunit;

namespace SolutionsValidator.Easy
{
    public class RemoveDuplicatesFromSortedListValidator
    {
        [Theory]
        [MemberData(nameof(SetupRemoveDuplicatesFromSortedListUseCases))]
        public void OnSuccess_Should_Find_Correct_Answer_For_RemoveDuplicatesFromSortedList(ListNode n, ListNode expectedResult)
        {
            //Arrange+Act
            var result = RemoveDuplicatesFromSortedList.SolveRemoveDuplicatesFromSortedList(n);

            //Assert
            result.Should().BeEquivalentTo(expectedResult);
        }

        public static IEnumerable<object[]> SetupRemoveDuplicatesFromSortedListUseCases()
        {
            yield return new object[]
            {
                new ListNode
                {
                    Val = 1,
                    Next = new ListNode
                    {
                        Val = 1,
                        Next  = new ListNode
                        {
                            Val = 2
                        }
                    }
                },
                new ListNode
                {
                    Val = 1,
                    Next = new ListNode
                    {
                        Val = 2
                    }
                }
            };

            yield return new object[]
            {
                new ListNode
                {
                    Val = 1,
                    Next = new ListNode
                    {
                        Val = 1,
                        Next  = new ListNode
                        {
                            Val = 2,
                            Next = new ListNode
                            {
                                Val = 3,
                                Next = new ListNode
                                {
                                    Val = 3
                                }
                            }
                        }
                    }
                },
                new ListNode
                {
                    Val = 1,
                    Next = new ListNode
                    {
                        Val = 2,
                        Next = new ListNode
                        {
                            Val = 3
                        }
                    }
                }
            };
        }
    }
}