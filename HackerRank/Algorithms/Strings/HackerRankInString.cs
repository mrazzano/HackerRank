using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class HackerRankInString : IQuestion
    {
        private const string question = "HackerRank in a String";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "2", "hereiamstackerrank", "hackerworld" };
            solution(args);
        }

        private static void solution(string[] args)
        {

            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                Console.WriteLine(stringExists(args[i + 1]) ? "YES" : "NO");
            }
        }

        private static bool stringExists(string s)
        {
            const string key = "hackerrank";

            var index = 0;
            foreach (var character in s)
            {
                if (character == key[index])
                {
                    index++;
                }

                if (index == key.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
