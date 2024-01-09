using LeetCodeCSharp.DTOs;

namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the MaximumDepthOfBinaryTree problem.
    /// </summary>
    /// 

    public static class MaximumDepthOfBinaryTree
    {
        /// <summary>
        /// Given the root of a binary tree, return its maximum depth.<br/>
        /// A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.<br/><br/>
        /// Example 1:
        /// Input: root = [3,9,20,null,null,15,7]
        /// Output: 3
        /// Example 2:
        /// Input: root = [1,null,2]
        /// Output: 2
        /// Constraints:
        /// The number of nodes in the tree is in the range[0, 104].
        /// -100 &lt;= Node.val &lt;= 100
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int SolveMaximumDepthOfBinaryTree(TreeNode? root)
        {
            var queue = new Queue<TreeNode>();
            var count = 0;

            if (root is null)
            {
                return 0;
            }

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var size = queue.Count;

                count++;

                for (var i = 0; i < size; i++)
                {
                    var temp = queue.Dequeue();

                    if (temp.Left is not null)
                    {
                        queue.Enqueue(temp.Left);
                    }

                    if (temp.Right is not null)
                    {
                        queue.Enqueue(temp.Right);
                    }
                }
            }

            return count;
        }
    }
}
