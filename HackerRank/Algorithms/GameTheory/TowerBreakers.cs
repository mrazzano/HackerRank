using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.GameTheory
{
    public class TowerBreakers : IQuestion
    {
        private const string question = "Tower Breakers";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "2", "2 2", "1 4" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var tokens = Array.ConvertAll(args[i + 1].Split(' '), Int32.Parse);
                var n = tokens[0];
                var m = tokens[1];

                if (n % 2 == 0 || m == 1)
                {
                    Console.WriteLine("2");
                }
                else
                {
                    Console.WriteLine("1");
                }
            }
        }
    }
}
