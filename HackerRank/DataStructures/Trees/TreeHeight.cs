using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.Trees
{
    public class TreeHeight : IQuestion
    {
        private const string question = "Height of a Binary Tree";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var root = Utility.GetBinaryTree(new[] { 3, 2, 5, 1, 4, 6, 7, 8 }, 1);
            Console.WriteLine(solution(root));
        }

        private static int solution(TreeNode root)
        {
            if (root == null)
                return -1;

            return Math.Max(solution(root.left), solution(root.right)) +1;
        }
    }
}
