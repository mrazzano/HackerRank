using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class WeightedUniformStrings : IQuestion
    {
        private const string question = "Weighted Uniform Strings";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "abccddde", "6", "1", "3", "12", "5", "9", "10" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var s = args[0];
            var n = Convert.ToInt32(args[1]);

            var last = ' ';
            var weight = 0;
            var weightedSums = new HashSet<int>();

            foreach (var item in s)
            {
                if (item != last)
                {
                    weight = 0;
                }
                weight += item - 'a' + 1;
                weightedSums.Add(weight);
                last = item;
            }

            for (var i = 0; i < n; i++)
            {
                var x = Convert.ToInt32(args[i + 2]);
                Console.WriteLine(weightedSums.Contains(x) ? "Yes" : "No");
            }
        }
    }
}
