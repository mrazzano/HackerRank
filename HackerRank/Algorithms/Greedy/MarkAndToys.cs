using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Greedy
{
    public class MarkAndToys : IQuestion
    {
        private const string question = "Mark and Toys";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "7 50", "1 12 5 111 200 1000 10" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens = args[0].Split(' ');
            var n = Convert.ToInt32(tokens[0]);
            var k = Convert.ToInt32(tokens[1]);
            var a = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            Array.Sort(a);

            var result = 0;
            var totalCost = 0;

            for (var i = 0; i < n; i++)
            {
                if (a[i] + totalCost <= k)
                {
                    result++;
                    totalCost += a[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
