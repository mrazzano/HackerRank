using HackerRank.Library;

namespace HackerRank.DataStructures.LinkedLists
{
    public class DeleteNode : IQuestion
    {
        private const string question = "Delete a Node from Linked List";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int position = 1;
            var head = Utility.GetLinkedList(new[] { 1, 2, 3 });
            
            var result = solution(head, position);
            Utility.PrintLinkedList(result);
        }

        private static Node solution(Node head, int position)
        {
            if (head == null)
                return null;
           
            if (position == 0)
            {
                return head.next;
            }

            var node = head;
            for (var i = 0; i < position-1; i++)
            {
                node = node.next;
            }
            node.next = node.next.next;
            return node;
        }
    }
}
