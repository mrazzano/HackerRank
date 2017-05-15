using System;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Algorithms.Greedy
{
    public class MaxPerimeterTriangle : IQuestion
    {
        private const string question = "Maximum Perimeter Triangle";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "5", "3 9 2 15 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var l = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            l = l.OrderByDescending(item=>item).ToArray();

            for (var i = 0; i < n - 2; i++)
            {
                if (l[i] < l[i + 1] + l[i + 2])
                {
                    Console.WriteLine("{0} {1} {2}", l[i+2], l[i+1], l[i]);
                    return;
                }
            }
            Console.WriteLine(-1);
        }
    }
}
