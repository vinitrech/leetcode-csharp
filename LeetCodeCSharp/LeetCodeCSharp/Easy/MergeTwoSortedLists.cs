namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the MergeTwoSortedLists problem.
    /// </summary>
    /// 

    public class ListNode
    {
        public int Val { get; set; }
        public ListNode? Next { get; set; }
        public ListNode(int val = 0, ListNode? next = null)
        {
            Val = val;
            Next = next;
        }
    }

    public static class MergeTwoSortedLists
    {

        /// <summary>
        ///You are given the heads of two sorted linked lists list1 and list2.<br/>
        ///Merge the two lists into one sorted list.The list should be made by splicing together the nodes of the first two lists.<br/>
        ///Return the head of the merged linked list.<br/><br/>
        ///Example 1:<br/>
        ///Input: list1 = [1,2,4], list2 = [1,3,4]<br/>
        ///Output: [1,1,2,3,4,4]<br/><br/>
        ///Example 2:<br/>
        ///Input: list1 = [], list2 = []<br/>
        ///Output: []<br/><br/>
        ///Example 3:<br/>
        ///Input: list1 = [], list2 = [0]<br/>
        ///Output: [0]<br/><br/>
        ///Constraints:<br/>
        ///The number of nodes in both lists is in the range[0, 50].<br/>
        ///-100 &lt;= Node.val &lt;= 100.<br/>
        ///Both list1 and list2 are sorted in non-decreasing order.
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static ListNode SolveMergeTwoSortedLists(ListNode list1, ListNode list2)
        {
            if (list1 is null) { return list2; }
            if (list2 is null) { return list1; }

            if (list1.Val <= list2.Val)
            {
                list1.Next = SolveMergeTwoSortedLists(list1.Next!, list2);
                return list1;
            }
            else
            {
                list2.Next = SolveMergeTwoSortedLists(list1, list2.Next!);
                return list2;
            }
        }
    }
}
