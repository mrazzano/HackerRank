using HackerRank.Library;

namespace HackerRank.DataStructures.LinkedLists
{
    public class InsertNodeAtPosition : IQuestion
    {
        private const string question = "Insert Node at a Specific Position in Linked List";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head = Utility.GetLinkedList(new[] { 1, 2, 4 });
            var result = solution(head, 3, 2);

            Utility.PrintLinkedList(result);
        }

        private static ListNode solution(ListNode head, int data, int position)
        {
            var newNode = new ListNode(data, null);
            if (position == 0)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                var node = head;
                while (position > 1)
                {
                    node = node.next;
                    position--;
                }
                newNode.next = node.next;
                node.next = newNode;
            }
            return head;
        }
    }
}
