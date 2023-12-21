namespace LeetCodeCSharp.DTOs
{
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
}
