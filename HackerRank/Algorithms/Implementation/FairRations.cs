using System;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class FairRations : IQuestion
    {
        private const string question = "Fair Rations";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "5", "2 3 4 5 6" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var b = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var result = 0;
            if (b.Sum() % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (var i = 0; i < n; i++)
            {
                if (b[i] % 2 == 0)
                    continue;

                b[i]++;
                b[i + 1]++;
                result += 2;
            }
            Console.WriteLine(result);
        }
    }
}
