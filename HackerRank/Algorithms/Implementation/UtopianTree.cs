using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class UtopianTree : IQuestion
    {
        private const string question = "Utopian Tree";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "3", "0", "1", "4" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var a0 = 0; a0 < t; a0++)
            {
                var n = Convert.ToInt32(args[a0 + 1]);
                var height = 1;
                for (var i = 0; i < n; i++)
                {
                    height += i % 2 == 0 ? height : 1;
                }
                Console.WriteLine(height);
            }
        }
    }
}
