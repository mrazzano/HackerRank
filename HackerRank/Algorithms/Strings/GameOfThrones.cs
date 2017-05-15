using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class GameOfThrones : IQuestion
    {
        private const string question = "Game of Thrones - I";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "aaabbbb" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var s = args[0];

            var counts = new int[26];
            foreach (var c in s)
            {
                counts[c - 'a']++;
            }

            var result = 0;
            for (var i = 0; i < 26; i++)
            {
                if (counts[i] % 2 != 0)
                {
                    result++;
                }
            }
            Console.WriteLine(result <= 1 ? "YES" : "NO");
        }
    }
}
