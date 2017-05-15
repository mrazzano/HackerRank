using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class BeautifulBinaryString : IQuestion
    {
        private const string question = "Beautiful Binary String";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "7", "0101010" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var b = args[1];

            var result = 0;
            for (var i = 0; i < n - 2; i++)
            {
                if (b[i] == '0' && b[i + 1] == '1' && b[i + 2] == '0')
                {
                    result++;
                    i += 2;
                }
            }
            Console.WriteLine(result);
        }
    }
}
