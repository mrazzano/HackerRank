using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.LinkedLists
{
    public class MergePointLinkedLists : IQuestion
    {
        private const string question = "Find Merge Point of Two Linked Lists";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head1 = Utility.GetLinkedList(new[] { 1, 3, 5, 6, 7 });
            var head2 = Utility.GetLinkedList(new[] { 2, 3 });

            Console.WriteLine(solution(head1, head2));
        }

        private static int solution(ListNode head1, ListNode head2)
        {
            var current1 = head1;
            var current2 = head2;

            while (current1.data != current2.data)
            {
                current1 = current1.next ?? current2;
                current2 = current2.next ?? current1;
            }
            return current1.data;
        }
    }
}
