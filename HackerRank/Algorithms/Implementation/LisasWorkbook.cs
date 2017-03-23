using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class LisasWorkbook : IQuestion
    {
        private const string question = "Lisa's Workbook";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "5 3", "4 2 6 1 10" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_n = args[0].Split(' ');
            var n = Convert.ToInt32(tokens_n[0]);
            var k = Convert.ToInt32(tokens_n[1]);
            var t = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var page = 0;
            var result = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = 1; j <= t[i]; j++)
                {
                    if (k == 1 || j % k == 1)
                    {
                        page++;
                    }

                    if (j == page)
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
