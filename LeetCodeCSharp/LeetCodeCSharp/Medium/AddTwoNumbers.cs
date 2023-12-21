using LeetCodeCSharp.DTOs;

namespace LeetCodeCSharp.Medium
{
    /// <summary>
    /// This is the solution for the AddTwoNumbers problem.
    /// </summary>
    /// 

    public static class AddTwoNumbers
    {
        /// <summary>
        ///You are given two non-empty linked lists representing two non-negative integers. <br/>
        ///The digits are stored in reverse order, and each of their nodes contains a single digit. <br/>
        ///Add the two numbers and return the sum as a linked list.<br/>
        ///You may assume the two numbers do not contain any leading zero, except the number 0 itself.<br/><br/>
        ///Example 1:<br/>
        ///Input: l1 = [2,4,3], l2 = [5,6,4]<br/>
        ///Output: [7,0,8]<br/>
        ///Explanation: 342 + 465 = 807.<br/><br/>
        ///Example 2:<br/>
        ///Input: l1 = [0], l2 = [0]<br/>
        ///Output: [0]<br/><br/>
        ///Example 3:<br/>
        ///Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]<br/>
        ///Output: [8,9,9,9,0,0,0,1]<br/><br/>
        ///Constraints:<br/>
        ///The number of nodes in each linked list is in the range[1, 100].<br/>
        ///0 &lt;= Node.val &lt;= 9<br/>
        ///It is guaranteed that the list represents a number that does not have leading zeros.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode? SolveAddTwoNumbers(ListNode? l1, ListNode? l2, int carry = 0)
        {
            if (l1 == null && l2 == null && carry == 0) return null;

            var total = (l1 != null ? l1.Val : 0) + (l2 != null ? l2.Val : 0) + carry;
            carry = total / 10;

            return new ListNode(total % 10, SolveAddTwoNumbers(l1?.Next, l2?.Next, carry));
        }
    }
}
