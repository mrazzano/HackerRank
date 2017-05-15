using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class LibraryFine : IQuestion
    {
        private const string question = "Library Fine";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "9 6 2015", "6 6 2015" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_d1 = args[0].Split(' ');
            var d1 = Convert.ToInt32(tokens_d1[0]);
            var m1 = Convert.ToInt32(tokens_d1[1]);
            var y1 = Convert.ToInt32(tokens_d1[2]);

            var tokens_d2 = args[1].Split(' ');
            var d2 = Convert.ToInt32(tokens_d2[0]);
            var m2 = Convert.ToInt32(tokens_d2[1]);
            var y2 = Convert.ToInt32(tokens_d2[2]);

            var returnedDate = new DateTime(y1, m1, d1);
            var expectedDate = new DateTime(y2, m2, d2);

            var result = 10000;
            if (returnedDate <= expectedDate)
            {
                result = 0;
            }
            else if (returnedDate.Month <= expectedDate.Month && returnedDate.Year <= expectedDate.Year)
            {
                result = Convert.ToInt32((returnedDate - expectedDate).TotalDays * 15);
            }
            else if (returnedDate.Year <= expectedDate.Year)
            {
                result = (returnedDate.Month - expectedDate.Month) * 500;
            }

            Console.WriteLine(result);
        }
    }
}
