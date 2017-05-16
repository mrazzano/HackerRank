using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.Trees
{
    public class PostorderTraversal : IQuestion
    {
        private const string question = "Postorder Traversal";

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
            solution(root.right);
            Console.Write("{0} ", root.data);
        }
    }
}
