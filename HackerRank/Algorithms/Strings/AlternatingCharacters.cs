using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class AlternatingCharacters : IQuestion
    {
        private const string question = "Alternating Characters";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "5", "AAAA", "BBBBB", "ABABABAB", "BABABA", "AAABBB" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var s = args[i + 1];

                var result = 0;
                for (var j = 1; j < s.Length; j++)
                {
                    if (s[j] == s[j - 1])
                        result++;
                }
                Console.WriteLine(result);
            }
        }
    }
}
