using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.LinkedLists
{
    public class DetectCycle : IQuestion
    {
        private const string question = "Cycle Detection";

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
                slow = slow.next;
                fast = fast.next.next;
                if (slow.data == fast.data)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
