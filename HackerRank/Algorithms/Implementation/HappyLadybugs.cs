using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class HappyLadybugs : IQuestion
    {
        private const string question = "Happy Ladybugs";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "2", "3 1 2", "4 10 100" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var tokens_n = args[i + 1].Split(' ');
                var n = Convert.ToInt32(tokens_n[0]);
                var a = Convert.ToInt32(tokens_n[1]);
                var b = Convert.ToInt32(tokens_n[2]);

                if (a == b)
                {
                    Console.WriteLine((n - 1) * a);
                }
                else
                {
                    if (a > b)
                    {
                        var temp = a;
                        a = b;
                        b = temp;
                    }
                    for (var j = 0; j <= n - 1; j++)
                    {

                        Console.Write(a * (n - 1 - j) + b * j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
