using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.WarmUp
{
    public class PlusMinus : IQuestion
    {
        private const string question = "Plus Minus";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "6", "-4 3 -9 0 4 1" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var arr = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            int zero = 0, positive = 0, negative = 0;
            foreach (var item in arr)
            {
                if (item > 0)
                    positive++;
                else if (item < 0)
                    negative++;
                else
                    zero++;
            }

            Console.WriteLine("{0:N6}", (double)positive / n);
            Console.WriteLine("{0:N6}", (double)negative / n);
            Console.WriteLine("{0:N6}", (double)zero / n);
        }
    }
}
