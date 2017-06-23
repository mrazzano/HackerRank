using HackerRank.Library;

namespace HackerRank.DataStructures.LinkedLists
{
    public class InsertNodeAtTail : IQuestion
    {
        private const string question = "Insert Node at the Tail of a Linked List";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head = Utility.GetLinkedList(new[]{1, 2});
            var result = solution(head, 3);

            Utility.PrintLinkedList(result);
        }

        private static ListNode solution(ListNode head, int data)
        {
            var node = head;
            while (node.next != null)
                node = node.next;
            
            node.next = new ListNode(data, null);
            return head;
        }
    }
}
