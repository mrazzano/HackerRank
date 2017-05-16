using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.Trees
{
    public class LevelorderTraversal : IQuestion
    {
        private const string question = "Level Order Traversal";

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

            var height = getHeight(root);
            for (var i = 1; i <= height; i++)
            {
                printLevel(root, i);
            }
        }

        private static void printLevel(TreeNode root, int level)
        {
            if (root == null)
                return;

            if (level == 1)
            {
                Console.Write("{0} ", root.data);
            }
            else if(level >0)
            {
                printLevel(root.left, level - 1);
                printLevel(root.right, level - 1);
            }

        }
        private static int getHeight(TreeNode root)
        {
            if (root == null)
                return 0;

            return Math.Max(getHeight(root.left), getHeight(root.right)) + 1;
        }
    }
}
