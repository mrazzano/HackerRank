using System;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{
    public class BinarySearchTree : IQuestion
    {
        private const string question = "Binary Search Tree";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var root = Utility.GetBinaryTree(new[] { 4, 2, 6, 1, 3, 5, 7 }, 1);

            solution(root);
            Console.WriteLine();
        }

        private static void solution(TreeNode root)
        {
            Console.WriteLine(isValidBST(
                root, Int32.MinValue, Int32.MaxValue) ? "Yes" : "No");
        }

        private static bool isValidBST(TreeNode root, int min, int max)
        {
            if (root == null) return true;

            if (root.data <= min || root.data >= max)
                return false;
            

            return isValidBST(root.left, min, root.data) && isValidBST(root.right, root.data, max);
        }
    }
}
