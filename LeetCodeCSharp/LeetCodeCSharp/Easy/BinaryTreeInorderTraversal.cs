using LeetCodeCSharp.DTOs;

namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the BinaryTreeInorderTraversal problem.
    /// </summary>
    /// 

    public static class BinaryTreeInorderTraversal
    {
        /// <summary>
        ///Given the root of a binary tree, return the inorder traversal of its nodes' values.<br/><br/>
        ///Example 1:<br/>
        ///Input: root = [1,null,2,3]<br/>
        ///Output: [1,3,2]<br/><br/>
        ///Example 2:<br/>
        ///Input: root = []<br/>
        ///Output: []<br/><br/>
        ///Example 3:<br/>
        ///Input: root = [1]<br/>
        ///Output: [1]<br/><br/>
        ///Constraints:<br/>
        ///The number of nodes in the tree is in the range[0, 100].<br/>
        ///-100 &lt;= Node.val &lt;= 100
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> SolveBinaryTreeInorderTraversal(TreeNode? root)
        {
            var traversal = new List<int>();
            var nodes = new Stack<TreeNode>();

            while (root is not null || nodes.Count > 0)
            {
                while (root is not null)
                {
                    nodes.Push(root);
                    root = root.Left;
                }

                root = nodes.Pop();
                traversal.Add(root.Val);
                root = root.Right;
            }

            return traversal;
        }
    }
}
