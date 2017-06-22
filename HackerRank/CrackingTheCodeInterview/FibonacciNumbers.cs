using System;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{
    public class FibonacciNumbers : IQuestion
    {
        private const string question = "Recursion: Fibonacci Numbers";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3" };
            solution(args);
        }

        private static void solution(string[] args)
        {

            var n = Convert.ToInt32(args[0]);
            Console.WriteLine(fibonacci(n));
        }

        private static int fibonacci(int n)
        {
            if (n < 2)
                return n;

            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}
