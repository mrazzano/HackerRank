using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.WarmUp
{
    public class SimpleArraySum : IQuestion
    {
        private const string question = "Simple Array Sum";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "6", "1 2 3 4 10 11" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var arr = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var result = 0;
            for (var i = 0; i < n; i++)
            {
                result += arr[i];
            }

            Console.WriteLine(result);
        }
    }
}
