using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class TwoStrings : IQuestion
    {
        private const string question = "Two Strings";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "2", "hello", "world", "hi", "world" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);

            var start = 0;
            var end = n * 2;
            while (start < end)
            {
                var setA = new HashSet<char>(args[start + 1]);
                var setB = new HashSet<char>(args[start + 2]);

                setA.IntersectWith(setB);

                Console.WriteLine(setA.Count > 0 ? "YES" : "NO");
                start += 2;
            }
        }
    }
}
