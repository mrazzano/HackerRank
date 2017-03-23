using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class DivisibleSumPairs : IQuestion
    {
        private const string question = "Divisible Sum Pairs";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "6 3", "1 3 2 6 1 2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_n = args[0].Split(' ');
            var n = Convert.ToInt32(tokens_n[0]);
            var k = Convert.ToInt32(tokens_n[1]);

            var a_temp = args[1].Split(' ');
            var a = Array.ConvertAll(a_temp, Int32.Parse);

            var result = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    if ((a[i] + a[j]) % k == 0)
                        result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
