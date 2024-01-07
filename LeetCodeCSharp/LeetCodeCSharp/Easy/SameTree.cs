using LeetCodeCSharp.DTOs;

namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the SameTree problem.
    /// </summary>
    /// 

    public static class SameTree
    {
        /// <summary>
        /// Given the roots of two binary trees p and q, write a function to check if they are the same or not.<br/>
        /// Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.<br/><br/>
        /// Example 1:<br/>
        /// Input: p = [1,2,3], q = [1,2,3]<br/>
        /// Output: true<br/><br/>
        /// Example 2:<br/>
        /// Input: p = [1,2], q = [1,null,2]<br/>
        /// Output: false<br/><br/>
        /// Example 3:<br/>
        /// Input: p = [1,2,1], q = [1,1,2]<br/>
        /// Output: false<br/><br/>
        /// Constraints:<br/>
        /// The number of nodes in both trees is in the range[0, 100].<br/>
        /// -104 &lt;= Node.val &lt;= 104
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static bool SolveSameTree(TreeNode? p, TreeNode? q)
        {
            var (nodesP, nodesQ) = (new Stack<TreeNode?>(), new Stack<TreeNode?>());

            nodesP.Push(p);
            nodesQ.Push(q);

            while (nodesP.Count > 0 && nodesQ.Count > 0)
            {
                var (nodeP, nodeQ) = (nodesP.Pop(), nodesQ.Pop());

                if (nodeP is null && nodeQ is null)
                {
                    continue;
                }
                else if (nodeP is null || nodeQ is null || nodeP.Val != nodeQ.Val)
                {
                    return false;
                }

                nodesP.Push(nodeP.Left);
                nodesQ.Push(nodeQ.Left);
                nodesP.Push(nodeP.Right);
                nodesQ.Push(nodeQ.Right);
            }

            return nodesP.Count == 0 && nodesQ.Count == 0;
        }
    }
}
