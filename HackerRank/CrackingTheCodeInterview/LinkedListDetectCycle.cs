using System;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{

    public class LinkedListDetectCycle : IQuestion
    {
        private const string question = "Linked Lists: Detect Cycle";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head = Utility.GetLinkedList(new[] { 1, 2, 3, 4 });
            head.next.next = head.next;

            Console.WriteLine(solution(head));
        }

        private static bool solution(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                if (slow == fast)
                    return true;

                slow = slow.next;
                fast = fast.next.next;
            }
            return false;
        }
    }
}
