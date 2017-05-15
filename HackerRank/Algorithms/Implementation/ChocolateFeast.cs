using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class ChocolateFeast : IQuestion
    {
        private const string question = "Chocolate Feast";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "10 2 5", "12 4 4", "6 2 2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var tokens_n = args[i + 1].Split(' ');
                var n = Convert.ToInt32(tokens_n[0]);
                var c = Convert.ToInt32(tokens_n[1]);
                var m = Convert.ToInt32(tokens_n[2]);

                var result = n / c;
                var wrappers = result;

                while (wrappers >= m)
                {
                    result++;
                    wrappers = (wrappers - m) + 1;
                }

                Console.WriteLine(result);
            }
        }
    }
}
