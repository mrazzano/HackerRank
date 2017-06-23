using System;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{
    public class LonelyInteger : IQuestion
    {
        private const string question = "Bit Manipulation: Lonely Integer";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "5", "0 0 1 2 1" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var a = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var result = 0;
            for (var i = 0; i < n; i++)
            {
                result ^= a[i];
            }
            Console.WriteLine(result);
        }
    }
}
