using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class ElectronicsShop : IQuestion
    {
        private const string question = "Electronics Shop";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "10 2 3", "3 1", "5 2 8" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens = args[0].Split(' ');
            var s = Convert.ToInt32(tokens[0]);
            var n = Convert.ToInt32(tokens[1]);
            var m = Convert.ToInt32(tokens[2]);

            var keyboards = Array.ConvertAll(args[1].Split(' '), Int32.Parse);
            var drives = Array.ConvertAll(args[2].Split(' '), Int32.Parse);

            var result = -1;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {
                    var total = keyboards[i] + drives[j];
                    if (total <= s)
                    {
                        result = Math.Max(result, total);
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
