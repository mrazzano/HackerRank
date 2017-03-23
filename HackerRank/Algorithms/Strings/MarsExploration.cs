using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class MarsExploration : IQuestion
    {
        private const string question = "Mars Exploration";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "SOSSPSSQSSOR" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            const string key = "SOS";

            var s = args[0];

            var result = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] != key[i%3])
                    result++;
            }
            Console.WriteLine(result);
        }
    }
}
