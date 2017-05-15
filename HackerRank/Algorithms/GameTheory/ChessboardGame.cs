using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.GameTheory
{
    public class ChessboardGame : IQuestion
    {
        private const string question = "A Chessboard Game";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "5 2", "5 3", "8 8" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var tokens = Array.ConvertAll(args[i + 1].Split(' '), Int32.Parse);
                var x = tokens[0];
                var y = tokens[1];

                x = x % 4;
                y = y % 4;
                if (x == 0 || x == 3 || y == 0 || y == 3)
                {
                    Console.WriteLine("First");
                }
                else
                {
                    Console.WriteLine("Second");
                }
            }
        }
    }
}
