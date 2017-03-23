using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class BeautifulDaysAtMovies : IQuestion
    {
        private const string question = "Beautiful Days at the Movies";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "20 23 6" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens = args[0].Split(' ');
            var i = Convert.ToInt32(tokens[0]);
            var j = Convert.ToInt32(tokens[1]);
            var k = Convert.ToInt32(tokens[2]);

            var result = 0;
            for (var n = i; n <= j; n++)
            {
                var reverse = reverseInt(n);
                if (Math.Abs(n - reverse) % k == 0)
                    result++;
            }
            Console.WriteLine(result);
        }

        private static int reverseInt(int input)
        {
            var left = input;
            var reverse = 0;
            while (left > 0)
            {
                var r = left % 10;
                reverse = reverse * 10 + r;
                left /= 10;
            }
            return reverse;
        }
    }
}
