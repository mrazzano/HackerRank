using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class CircularArrayRotation : IQuestion
    {
        private const string question = "Circular Array Rotation";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "3 2 3", "1 2 3", "0", "1", "2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_n = args[0].Split(' ');
            var n = Convert.ToInt32(tokens_n[0]);
            var k = Convert.ToInt32(tokens_n[1]);
            var q = Convert.ToInt32(tokens_n[2]);
            var input = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            k = k % n;

            Array.Reverse(input);
            Array.Reverse(input, 0, k);
            Array.Reverse(input, k, n - k);

            for (var i = 0; i < q; i++)
            {
                var m = Convert.ToInt32(args[i + 2]);
                Console.WriteLine(input[m]);
            }
        }
    }
}
