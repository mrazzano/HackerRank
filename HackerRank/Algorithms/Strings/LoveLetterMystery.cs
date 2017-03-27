using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class LoveLetterMystery : IQuestion
    {
        private const string question = "The Love Letter Mystery";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "4", "abc", "abcba", "abcd","cba" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);

            for (var i = 0; i < n; i++)
            {
                var s = args[i+1];

                var result = 0;
                for (var j = 0; j < s.Length/2; j++)
                {
                    result += Math.Abs(s[j] - s[(s.Length - j - 1)]);
                }
                Console.WriteLine(result);
            }
        }
    }
}
