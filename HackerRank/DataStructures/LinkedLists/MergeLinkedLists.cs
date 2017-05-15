using HackerRank.Library;

namespace HackerRank.DataStructures.LinkedLists
{
    public class MergeLinkedLists : IQuestion
    {
        private const string question = "Merge Linked Lists";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var head1 = Utility.GetLinkedList(new[] { 1, 3, 5, 6 });
            var head2 = Utility.GetLinkedList(new[] { 2, 4, 7 });

            Utility.PrintLinkedList(solution(head1, head2));
        }

        private static Node solution(Node head1, Node head2)
        {
            if (head1 == null && head2 == null)
                return null;

            if (head1 == null)
                return head2;

            if (head2 == null)
                return head1;

            if (head1.data < head2.data)
            {
                head1.next = solution(head1.next, head2);
                return head1;
            }

            head2.next = solution(head1, head2.next);
            return head2;
        }
    }
}
