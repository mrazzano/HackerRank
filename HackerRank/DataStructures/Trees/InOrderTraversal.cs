using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.Trees
{
    public class InorderTraversal : IQuestion
    {
        private const string question = "Inorder Traversal";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var root = Utility.GetBinaryTree(new[] { 3, 5, 2, 1, 4, 6 }, 1);

            solution(root);
            Console.WriteLine();
        }

        private static void solution(TreeNode root)
        {
            if (root == null)
                return;

            solution(root.left);
            Console.Write("{0} ", root.data);
            solution(root.right);
        }
    }
}
