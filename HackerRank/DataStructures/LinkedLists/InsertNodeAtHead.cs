using HackerRank.Library;

namespace HackerRank.DataStructures.LinkedLists
{
    public class InsertNodeAtHead : IQuestion
    {
        private const string question = "Insert Node at the Head of a Linked List";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head = Utility.GetLinkedList(new[]{2, 3});
            var result = solution(head, 1);

            Utility.PrintLinkedList(result);
        }

        private static Node solution(Node head, int data)
        {
            var node = new Node(data, head);
            return node;
        }
    }
}
