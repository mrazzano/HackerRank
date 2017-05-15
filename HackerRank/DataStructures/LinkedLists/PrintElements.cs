using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.LinkedLists
{
    public class PrintElements : IQuestion
    {
        private const string question = "Print Elements of a Linked List";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head = Utility.GetLinkedList(new[] { 1, 2, 3 });
            solution(head);
        }

        private static void solution(Node head)
        {
            var next = head;
            while (next != null)
            {
                Console.WriteLine(next.data);
                next = next.next;
            }
        }
    }
}
