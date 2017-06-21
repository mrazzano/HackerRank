using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class MigratoryBirds : IQuestion
    {
        private const string question = "Migratory Birds";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "6", "1 4 4 4 5 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var ar = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var map = new SortedDictionary<int, int>();
            for (var i = 0; i < n; i++)
            {
                if (map.ContainsKey(ar[i]))
                {
                    map[ar[i]]++;
                }
                else
                {
                    map[ar[i]] = 1;
                }
            }

            var max = Int32.MinValue;
            var result = Int32.MaxValue;
            foreach (var key in map.Keys)
            {
                if (map[key] > max)
                {
                    result = key;
                    max = map[key];
                }

            }
            Console.WriteLine(result);
        }
    }
}
