using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.BitManipulation
{
    public class SumVsXOR : IQuestion
    {
        private const string question = "Sum vs XOR";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "5" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt64(args[0]);

            var result = 0;
            while (n > 0)
            {
                if ((n & 1) == 0)
                {
                    result++;
                }
                n >>= 1;
            }
            Console.WriteLine(Math.Pow(2, result));
        }
    }
}
