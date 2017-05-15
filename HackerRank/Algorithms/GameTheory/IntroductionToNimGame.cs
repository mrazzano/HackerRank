using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.GameTheory
{
    public class IntroductionToNimGame : IQuestion
    {
        private const string question = "Introduction to Nim Game";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "2", "2", "1 1", "3", "2 1 4" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            
            var start = 0;
            var end = t * 2;
            while (start < end)
            {
           
                var n = Convert.ToInt32(args[start + 1]);
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
