using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Greedy
{
    public class PriyankaAndToys : IQuestion
    {
        private const string question = "Priyanka and Toys";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "5", "1 2 3 17 10" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var w = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            Array.Sort(w);

            var result = 1;
            var current = w[0];
            for (var i = 0; i < n; i++)
            {
                var weight = w[i];
                if (weight > current + 4)
                {
                    result++;
                    current = weight;
                }
            }
          
            Console.WriteLine(result);
        }
    }
}
