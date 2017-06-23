using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{
    public class DavisStaircase : IQuestion
    {
        private const string question = "Recursion: Davis' Staircase";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "1", "3", "7" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var s = Convert.ToInt32(args[0]);
            for (var i = 0; i < s; i++)
            {
                var n = Convert.ToInt32(args[i + 1]);
                Console.WriteLine(climbStairs(n));
            }
        }

        private static int climbStairs(int n)
        {
            var map = new Dictionary<Int32, Int32>
            {
                {0, 0}, 
                {1, 1},
                {2, 2},
                {3, 4}
            };

            for (var i = 4; i <= n; i++)
                map.Add(i, map[i - 1] + map[i - 2] + map[i - 3]);

            return map[n];
        }
    }
}
