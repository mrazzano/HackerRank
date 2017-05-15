using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class SaveThePrisoner : IQuestion
    {
        private const string question = "Save the Prisoner";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "1", "5 2 1" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);

            var tokens = args[1].Split(' ');
            var n = Convert.ToInt32(tokens[0]);
            var m = Convert.ToInt32(tokens[1]);
            var s = Convert.ToInt32(tokens[2]);

            for (var i = 0; i < t; i++)
            {
                Console.WriteLine(((m - 1) + (s - 1)) % n + 1);
            }
        }
    }
}
