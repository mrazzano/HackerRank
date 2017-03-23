using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class Kangaroo : IQuestion
    {
        private const string question = "Kangaroo";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            const string args = "0 3 4 2";
            solution(args);
        }

        private static void solution(string args)
        {
            var tokens_x1 = args.Split(' ');
            var x1 = Convert.ToInt32(tokens_x1[0]);
            var v1 = Convert.ToInt32(tokens_x1[1]);
            var x2 = Convert.ToInt32(tokens_x1[2]);
            var v2 = Convert.ToInt32(tokens_x1[3]);

            var dx = x1 - x2;
            var dv = v2 - v1;
            if ((dx < 0 && dv < 0) || (dx > 0 && dv > 0))
            {
                if (dx % dv == 0)
                {
                    Console.WriteLine("YES");
                }
            }
            Console.WriteLine("NO");
        }
    }
}
