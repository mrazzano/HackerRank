using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.LinkedLists
{
    public class NthFromLastNode : IQuestion
    {
        private const string question = "Nth From Last Node";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            const int position = 2;
            var head = Utility.GetLinkedList(new[] { 1, 3, 4, 6 });

            var result = solution(head, position);
            Console.WriteLine(result.data);
        }

        private static ListNode solution(ListNode head, int position)
        {
            if (head == null)
                return null;

            var slow = head;
            var fast = head;
            for (var i = 0; i < position; i++)
                fast = fast.next;


            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            return slow;
        }
    }
}
