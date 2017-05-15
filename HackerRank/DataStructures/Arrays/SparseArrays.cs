using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.DataStructures.Arrays
{
    public class SparseArrays : IQuestion
    {
        private const string question = "Sparse Arrays";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "4", "aba", "baba", "aba", "xzxb", "3", "aba", "xzxb", "ab" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);

            var strings = new List<string>();
            for (var i = 0; i < n; i++)
            {
                strings.Add(args[i + 1]);
            }

            var start = n + 1;
            var end = start + Convert.ToInt32(args[start]);
            for (var i = start; i < end; i++)
            {
                Console.WriteLine(strings.FindAll(x => x == args[i + 1]).Count);
            }
        }
    }
}
