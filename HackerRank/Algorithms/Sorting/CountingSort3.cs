using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting
{
    public class CountingSort3 : IQuestion
    {
        private const string question = "Counting Sort - 3";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "10", "4 that", "3 be", "0 to", "1 be", "5 question", "1 or", "2 not", "4 is", "2 to", "4 the" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);

            var count = new int[100];
            for (var i = 0; i < n; i++)
            {
                var tokens = args[i + 1].Split(' ');
                var number = Convert.ToInt32(tokens[0]);
                count[number]++;
            }

            var sum = 0;
            foreach (var item in count)
            {
                sum += item;
                Console.Write("{0} ", sum);
            }
            Console.WriteLine();
        }
    }
}
