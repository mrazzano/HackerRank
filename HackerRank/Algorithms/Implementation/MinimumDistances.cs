using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class MinimumDistances : IQuestion
    {
        private const string question = "Minimum Distances";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "6", "7 1 3 4 1 7" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var a = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var result = Int32.MaxValue;
            for (var i = 0; i < n; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        result = Math.Min(result, j - i);
                    }
                }
            }

            result = result == Int32.MaxValue ? -1 : result;
            Console.WriteLine(result);
        }
    }
}
