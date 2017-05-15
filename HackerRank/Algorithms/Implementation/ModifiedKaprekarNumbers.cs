using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class ModifiedKaprekarNumbers : IQuestion
    {
        private const string question = "Modified Kaprekar Numbers";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "1", "100" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var p = Convert.ToInt32(args[0]);
            var q = Convert.ToInt32(args[1]);

            var validRange = false;
            for (long i = p; i <= q; i++)
            {
                var square = (i * i).ToString();

                var left = square.Substring(0, square.Length / 2);
                var right = square.Substring(square.Length / 2);

                var leftNumber = String.IsNullOrEmpty(left) ? 0 : Int32.Parse(left);
                var rightNumber = String.IsNullOrEmpty(right) ? 0 : Int32.Parse(right);

                if (leftNumber + rightNumber == i)
                {
                    Console.Write("{0} ", i);
                    validRange = true;
                }
            }

            if (!validRange)
                Console.Write("INVALID RANGE");

            Console.WriteLine();
        }
    }
}
