using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.WarmUp
{
    public class CompareTheTriplets : IQuestion
    {
        private const string question = "Compare the Triplets";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "5 6 7", "3 6 10" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_a0 = args[0].Split(' ');
            var a0 = Convert.ToInt32(tokens_a0[0]);
            var a1 = Convert.ToInt32(tokens_a0[1]);
            var a2 = Convert.ToInt32(tokens_a0[2]);

            var tokens_b0 = args[1].Split(' ');
            var b0 = Convert.ToInt32(tokens_b0[0]);
            var b1 = Convert.ToInt32(tokens_b0[1]);
            var b2 = Convert.ToInt32(tokens_b0[2]);

            var totalA = 0;
            var totalB = 0;

            if (a0 > b0)
                totalA++;
            else if (a0 < b0)
                totalB++;

            if (a1 > b1)
                totalA++;
            else if (a1 < b1)
                totalB++;

            if (a2 > b2)
                totalA++;
            else if (a2 < b2)
                totalB++;

            Console.WriteLine("{0} {1}", totalA, totalB);
        }
    }
}
