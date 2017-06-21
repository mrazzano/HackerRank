using System;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Algorithms.WarmUp
{
    public class BirthdayCakeCandles : IQuestion
    {
        private const string question = "Birthday Cake Candles";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "4", "3 2 1 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var ar = Array.ConvertAll(args[1].Split(' '), Int32.Parse);
            ar = ar.OrderByDescending(x => x).ToArray();

            var result = 1;
            var max = ar[0];
            for (var i = 1; i < n; i++)
            {
                if (ar[i] != max)
                {
                    break;
                }
                result++;
            }
            Console.WriteLine(result);
        }
    }
}
