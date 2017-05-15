using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class SherlockAndSquares : IQuestion
    {
        private const string question = "Sherlock and Squares";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "2", "3 9", "17 24" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var tokens = args[i + 1].Split(' ');
                var a = Convert.ToInt32(tokens[0]);
                var b = Convert.ToInt32(tokens[1]);

                Console.WriteLine(Convert.ToInt32(Math.Floor(Math.Sqrt(b)) - Math.Ceiling(Math.Sqrt(a)) + 1));
            }
        }
    }
}
