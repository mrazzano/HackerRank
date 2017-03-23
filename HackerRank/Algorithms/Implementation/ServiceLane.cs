using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class ServiceLane : IQuestion
    {
        private const string question = "Service Lane";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "8 5", "2 3 1 2 3 2 3 3", "0 3", "4 6", "6 7", "3 5", "0 7" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_n = args[0].Split(' ');
            var t = Convert.ToInt32(tokens_n[1]);
            var width = Array.ConvertAll(args[1].Split(' '), Int32.Parse);
            
            for (var a0 = 0; a0 < t; a0++)
            {
                var tokens_i = args[a0 + 2].Split(' ');
                var i = Convert.ToInt32(tokens_i[0]);
                var j = Convert.ToInt32(tokens_i[1]);

                var result = Int32.MaxValue;
                for (var k = i; k <= j; k++)
                {
                    result = Math.Min(result, width[k]);
                }
                Console.WriteLine(result);
            }
        }
    }
}
