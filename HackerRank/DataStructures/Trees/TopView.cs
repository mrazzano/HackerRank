using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.Trees
{
    public class TopView : IQuestion
    {
        private const string question = "Top View";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var root = Utility.GetBinaryTree(new[] { 3, 5, 2, 1, 4, 6, 7 }, 1);
            solution(root);

            Console.WriteLine();
        }

        private static void solution(TreeNode root)
        {
            printLeft(root.left);
            Console.Write("{0} ", root.data);
            printRight(root.right);
        }

        private static void printLeft(TreeNode root)
        {
            if (root == null)
                return;

            printLeft(root.left);
            Console.Write("{0} ", root.data);
        }

        private static void printRight(TreeNode root)
        {
            if (root == null)
                return;

            Console.Write("{0} ", root.data);
            printRight(root.right);
        }
    }
}
