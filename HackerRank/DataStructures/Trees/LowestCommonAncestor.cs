using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.Trees
{
    public class LowestCommonAncestor : IQuestion
    {
        private const string question = "Lowest Common Ancestor";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int node1 = 1;
            const int node2 = 7;
            var root = Utility.GetBinaryTree(new[] { 4, 2, 7, 1, 3, 6 }, 1);

            var result = solution(root, node1, node2);
            Console.WriteLine(result.data);
        }

        private static TreeNode solution(TreeNode root, int node1, int node2)
        {
            if (root == null)
                return null;

            if (root.data == node1 || root.data == node2)
            {
                return root;
            }

            var lca1 = solution(root.left, node1, node2);
            var lca2 = solution(root.right, node1, node2);

            if (lca1 != null && lca2 != null)
            {
                return root;
            }

            return lca1 ?? lca2;
        }
    }
}
