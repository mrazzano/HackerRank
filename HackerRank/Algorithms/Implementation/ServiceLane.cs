using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class ServiceLane : IQuestion
    {
        private const string question = "Service Lane";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "8 5", "2 3 1 2 3 2 3 3", "0 3", "4 6", "6 7", "3 5", "0 7" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0].Split(' ')[1]);
            var width = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            for (var i = 0; i < t; i++)
            {
                var tokens = args[i + 2].Split(' ');
                var j = Convert.ToInt32(tokens[0]);
                var k = Convert.ToInt32(tokens[1]);

                var result = Int32.MaxValue;
                for (var l = j; l <= k; l++)
                {
                    result = Math.Min(result, width[l]);
                }
                Console.WriteLine(result);
            }
        }
    }
}
