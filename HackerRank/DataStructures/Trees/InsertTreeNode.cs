using HackerRank.Library;

namespace HackerRank.DataStructures.Trees
{
    public class InsertTreeNode : IQuestion
    {
        private const string question = "Binary Search Tree Insertion";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int value = 6;
            var root = Utility.GetBinaryTree(new[] { 4, 2, 7, 1, 3 }, 1);

            Utility.PrintTreePreOrder(solution(root, value));
        }

        private static TreeNode solution(TreeNode root, int value)
        {
            if (root == null)
            {
                var node = new TreeNode(value);
                root = node;
            }

            else if (value < root.data)
            {
                root.left = solution(root.left, value);
            }
            else
            {
                root.right = solution(root.right, value);
            }
            return root;
        }
    }
}
