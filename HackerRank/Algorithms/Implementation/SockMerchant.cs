using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class SockMerchant : IQuestion
    {
        private const string question = "Sock Merchant";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "9", "10 20 20 10 10 30 50 10 20" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var c = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            Array.Sort(c);

            var i = 1;
            var result = 0;
            while (i < n)
            {
                if (c[i] == c[i - 1])
                {
                    result++;
                    i += 2;
                }
                else
                {
                    i += 1;
                }
            }

            Console.WriteLine(result);
        }
    }
}
