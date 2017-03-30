using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class DrawingBook : IQuestion
    {
        private const string question = "Drawing Book";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "6", "2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var p = Convert.ToInt32(args[1]);

            Console.WriteLine(Math.Min(p / 2, (n - p) / 2));
        }
    }
}
