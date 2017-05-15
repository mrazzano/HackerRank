using HackerRank.Library;

namespace HackerRank.DataStructures.LinkedLists
{
    public class ReverseLinkedList : IQuestion
    {
        private const string question = "Reverse Linked List";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head = Utility.GetLinkedList(new[] { 1, 2, 3 });
            
            var result = solution(head);
            Utility.PrintLinkedList(result);
        }

        private static Node solution(Node head)
        {
            Node newHead = null;
            while (head != null)
            {
                var next = head.next;
                head.next = newHead;
                newHead = head;
                head = next;
            }
            return newHead;
        }
    }
}
