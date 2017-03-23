using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class SequenceEquation : IQuestion
    {
        private const string question = "Sequence Equation";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "3", "2 3 1" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var p = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var hash = new Dictionary<int, int>();
            for (var i = 1; i <= n; i++)
                hash.Add(p[i - 1], i);

            for (var i = 1; i <= n; i++)
                Console.WriteLine(hash[hash[i]]);
        }
    }
}
