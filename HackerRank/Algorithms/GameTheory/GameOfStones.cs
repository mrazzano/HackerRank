using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.GameTheory
{
    public class GameOfStones : IQuestion
    {
        private const string question = "Game of Stones";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "8", "1", "2", "3", "4", "5", "6", "7", "10" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var s = Convert.ToInt32(args[i + 1]);
                var x = s % 7;

                if (x == 0 || x == 1)
                {
                    Console.WriteLine("Second");
                }
                else
                {
                    Console.WriteLine("First");
                }
            }
        }
    }
}
