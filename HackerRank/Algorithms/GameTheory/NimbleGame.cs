using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.GameTheory
{
    public class NimbleGame : IQuestion
    {
        private const string question = "Nimble Game";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "2", "5", "0 2 3 0 6", "4", "0 0 0 0" };
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
                    if(s[i] % 2 ==1)
                        result ^= i;
                }

                Console.WriteLine(result == 0 ? "Second" : "First");
                start += 2;
            }
        }
    }
}
