﻿using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class FindDigits : IQuestion
    {
        private const string question = "Find Digits";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "2", "12", "1012" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var n = Convert.ToInt32(args[i + 1]);
                
                var number = n;
                var result = 0;
                while (number > 0)
                {
                    var digit = number % 10;
                    if (digit != 0 && n % digit == 0)
                    {
                        result++;
                    }
                    number /= 10;

                }
                Console.WriteLine(result);
            }
        }
    }
}
