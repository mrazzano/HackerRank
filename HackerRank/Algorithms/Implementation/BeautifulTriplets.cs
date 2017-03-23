using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class BeautifulTriplets : IQuestion
    {
        private const string question = "Beautiful Triplets";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "7 3", "1 2 4 5 7 8 10" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_n = args[0].Split(' ');
            var n = Convert.ToInt32(tokens_n[0]);
            var d = Convert.ToInt32(tokens_n[1]);

            var a = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var result = 0;
            var hash = new HashSet<int>();
            for (var i = 0; i < n; i++)
            {
                if (hash.Contains(a[i] - d) && hash.Contains(a[i] - 2 * d))
                {
                    result++;
                }
                hash.Add(a[i]);
            }
            Console.WriteLine(result);
        }
    }
}
