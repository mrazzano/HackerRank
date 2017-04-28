using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.LinkedLists
{
    public class InsertNodeAtTail : IQuestion
    {
        private const string question = "Insert Node at the Tail of a Linked List";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var head = Utility.GetLinkedList(new[]{1, 2});
            var result = solution(head, 3);

            Console.WriteLine(Utility.PrintLinkedList(result));
        }

        private static Node solution(Node head, int data)
        {
            var node = head;
            while (node.next != null)
            {
                node = node.next;
            }
            node.next = new Node(data, null);
            return head;
        }
    }
}
