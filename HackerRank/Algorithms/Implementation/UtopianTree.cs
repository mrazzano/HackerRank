﻿using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class UtopianTree : IQuestion
    {
        private const string question = "Utopian Tree";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "0", "1", "4" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var n = Convert.ToInt32(args[i + 1]);
                var height = 1;
                for (var j = 0; j < n; j++)
                {
                    height += j % 2 == 0 ? height : 1;
                }
                Console.WriteLine(height);
            }
        }
    }
}
