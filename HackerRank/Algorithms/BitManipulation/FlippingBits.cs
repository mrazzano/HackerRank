using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.BitManipulation
{
    public class FlippingBits : IQuestion
    {
        private const string question = "Flipping Bits";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "2147483647", "1", "0" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var n = Convert.ToUInt32(args[i + 1]);
                Console.WriteLine(~n);
            }
        }
    }
}
