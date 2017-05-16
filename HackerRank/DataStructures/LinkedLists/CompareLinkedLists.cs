using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.LinkedLists
{
    public class CompareLinkedLists : IQuestion
    {
        private const string question = "Compare Linked Lists";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head1 = Utility.GetLinkedList(new[] { 1, 2, 3 });
            var head2 = Utility.GetLinkedList(new[] { 1, 2, 3 });

            Console.WriteLine(solution(head1, head2));
        }

        private static bool solution(ListNode head1, ListNode head2)
        {
            while (head1 != null && head2 != null)
            {
                if (head1.data != head2.data)
                    return false;

                head1 = head1.next;
                head2 = head2.next;
            }

            return (head1 == null && head2 == null);
        }
    }
}
