using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Greedy
{
    public class MinimumAbsoluteDifference : IQuestion
    {
        private const string question = "Minimum Absolute Difference";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "3 -7 0" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var a = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            Array.Sort(a);
            var result = Int32.MaxValue;
            for (var i = 1; i < n; i++)
            {
                result = Math.Min(result, Math.Abs(a[i] - a[i - 1]));
            }

            Console.WriteLine(result);
        }
    }
}
