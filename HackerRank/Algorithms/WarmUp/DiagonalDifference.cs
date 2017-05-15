using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.WarmUp
{
    public class DiagonalDifference : IQuestion
    {
        private const string question = "Diagonal Difference";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "11 2 4", "4 5 6", "10 8 -12" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var a = new int[n][];
            for (var i = 0; i < n; i++)
            {
                a[i] = Array.ConvertAll(args[i + 1].Split(' '), Int32.Parse);
            }

            var diagonal1 = 0;
            var diagonal2 = 0;

            var min = 0;
            var max = n - 1;

            for (var row = 0; row < n; row++)
            {
                diagonal1 += a[row][min];
                diagonal2 += a[row][max];

                min++;
                max--;
            }

            Console.WriteLine(Math.Abs(diagonal1 - diagonal2));
        }
    }
}
