using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class EqualizeTheArray : IQuestion
    {
        private const string question = "Equalize The Array";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "5", "3 3 2 1 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var c = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var result = 0;
            var hash = new Dictionary<int, int>();

            for (var i = 0; i < n; i++)
            {
                var key = c[i];
                if (!hash.ContainsKey(key))
                {
                    hash.Add(key, 0);
                }
                else
                {
                    hash[key]++;
                    result = Math.Max(result, hash[key]);
                }
            }
            Console.WriteLine(n - result - 1);
        }
    }
}
