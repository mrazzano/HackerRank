using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class StrangeCounter : IQuestion
    {
        private const string question = "Strange Counter";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "4" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt64(args[0]);

            long value = 3;
            while (t > value)
            {
                t -= value;
                value *= 2;
            }
            Console.WriteLine(value - t + 1);
        }
    }
}
