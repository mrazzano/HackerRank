using System;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Algorithms.Greedy
{
    public class MarksCakewalk : IQuestion
    {
        private const string question = "Marc's Cakewalk";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "1 3 2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var calories = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            calories = calories.OrderByDescending(item => item).ToArray();

            long result = 0;
            for (var i = 0; i < n; i++)
            {
                result += (long)(calories[i] * Math.Pow(2, i));
            }

            Console.WriteLine(result);
        }
    }
}
