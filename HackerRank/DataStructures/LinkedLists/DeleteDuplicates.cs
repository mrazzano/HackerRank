using HackerRank.Library;

namespace HackerRank.DataStructures.LinkedLists
{
    public class DeleteDuplicates : IQuestion
    {
        private const string question = "Delete Duplicates from Linked List";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head = Utility.GetLinkedList(new[] { 1, 1, 3, 3, 5, 6 });

            Utility.PrintLinkedList(solution(head));
        }

        private static Node solution(Node head)
        {
            if (head == null)
                return null;

            var result = head;
            while (head.next!=null)
            {
                if (head.data != head.next.data)
                {
                    head = head.next;
                }
                else
                {
                    head.next = head.next.next;
                }
            }
            return result;
        }
    }
}
