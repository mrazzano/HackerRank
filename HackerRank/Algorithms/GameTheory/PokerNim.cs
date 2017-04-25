using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.GameTheory
{
    public class PokerNim : IQuestion
    {
        private const string question = "Poker Nim";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "2", "2 5", "1 2", "3 5", "2 1 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            
            var start = 0;
            var end = t * 2;
            while (start < end)
            {

                var tokens = Array.ConvertAll(args[start + 1].Split(' '), Int32.Parse);
                var n = tokens[0];
                
                var s = Array.ConvertAll(args[start + 2].Split(' '), Int32.Parse);

                var result = 0;
                for (var i = 0; i < n; i++)
                {
                    result ^= s[i];
                }

                Console.WriteLine(result == 0 ? "Second" : "First");
                start += 2;
            }
        }
    }
}
