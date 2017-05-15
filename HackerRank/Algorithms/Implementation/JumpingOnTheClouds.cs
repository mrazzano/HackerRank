using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class JumpingOnTheClouds : IQuestion
    {
        private const string question = "Jumping on the Clouds";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "7", "0 0 1 0 0 1 0" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var c = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var start = 0;
            var result = 0;
            var end = n - 1;

            while (start != end)
            {
                if (start + 2 < n && c[start + 2] == 0)
                {
                    result++;
                    start += 2;
                }
                else if (c[start + 1] == 0)
                {
                    result++;
                    start++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
