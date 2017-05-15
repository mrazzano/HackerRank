using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class StringConstruction : IQuestion
    {
        private const string question = "String Construction";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "2", "abcd", "abab" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            for (var i = 0; i < n; i++)
            {
                var s = args[i + 1];

                var hash = new HashSet<char>(s);
                Console.WriteLine(hash.Count);
            }
        }
    }
}