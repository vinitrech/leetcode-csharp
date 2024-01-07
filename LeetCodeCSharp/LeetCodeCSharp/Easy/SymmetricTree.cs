using LeetCodeCSharp.DTOs;

namespace LeetCodeCSharp.Easy
{
    /// <summary>
    /// This is the solution for the SymmetricTree problem.
    /// </summary>
    /// 

    public static class SymmetricTree
    {
        /// <summary>
        /// Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).<br/><br/>
        /// Example 1:<br/>
        /// Input: root = [1,2,2,3,4,4,3]<br/>
        /// Output: true<br/><br/>
        /// Example 2:<br/>
        /// Input: root = [1,2,2,null,3,null,3]<br/>
        /// Output: false<br/><br/>
        /// Constraints:<br/>
        /// The number of nodes in the tree is in the range[1, 1000].<br/>
        /// -100 &lt;= Node.val &lt;= 100
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool SolveSymmetricTree(TreeNode? root)
        {
            var subTrees = new Stack<(TreeNode, TreeNode)>();

            subTrees.Push((root.Left, root.Right));

            while (subTrees.Count > 0)
            {
                switch (subTrees.Pop())
                {
                    case (null, null):
                        continue;
                    case (null, _) or (_, null):
                        return false;
                    case (TreeNode left, TreeNode right) when left.Val != right.Val:
                        return false;
                    case (TreeNode left, TreeNode right) when left.Val == right.Val:
                        subTrees.Push((left.Left, right.Right));
                        subTrees.Push((left.Right, right.Left));
                        break;
                }
            }

            return true;
        }
    }
}
