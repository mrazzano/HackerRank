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
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "2", "hello", "world", "hi", "world" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            for (var i = 0; i < n * 2; i += 2)
            {
                var setA = new HashSet<char>(args[i + 1]);
                var setB = new HashSet<char>(args[i + 2]);

                setA.IntersectWith(setB);

                Console.WriteLine(setA.Count > 0 ? "YES" : "NO");
            }
        }
    }
}
