using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.BitManipulation
{
    public class LonelyInteger : IQuestion
    {
        private const string question = "Lonely Integer";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "3", "1 1 2" };
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
