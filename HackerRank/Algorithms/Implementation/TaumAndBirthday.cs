using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class TaumAndBirthday : IQuestion
    {
        private const string question = "Taum and Birthday";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "5", "10 10", "1 1 1", "5 9", "2 3 4", "3 6", "9 1 1", "7 7", "4 2 1", "3 3", "1 9 2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);

            var start = 0;
            var end = t * 2;
            while (start < end)
            {
                var tokens_b = args[start + 1].Split(' ');
                var b = Convert.ToInt64(tokens_b[0]);
                var w = Convert.ToInt64(tokens_b[1]);

                var tokens_x = args[start + 2].Split(' ');
                var x = Convert.ToInt64(tokens_x[0]);
                var y = Convert.ToInt64(tokens_x[1]);
                var z = Convert.ToInt64(tokens_x[2]);

                var priceB = Math.Min(x, y + z);
                var priceW = Math.Min(y, x + z);

                Console.WriteLine(b * priceB + w * priceW);
                start += 2;
            }
        }
    }
}
