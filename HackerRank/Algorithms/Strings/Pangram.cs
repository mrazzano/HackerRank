using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class Pangram : IQuestion
    {
        private const string question = "Pangram";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "We promptly judged antique ivory buckles for the next prize" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var s = args[0].ToLower();
            for (var i = 0; i < 26; i++)
            {
                var current = (char) (97 + i);
                if (!s.Contains(current.ToString()))
                {
                    Console.WriteLine("not pangram");
                    return;
                }
            }

            Console.WriteLine("pangram");
        }
    }
}
