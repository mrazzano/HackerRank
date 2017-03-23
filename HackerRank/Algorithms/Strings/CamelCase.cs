using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class CamelCase : IQuestion
    {
        private const string question = "CamelCase";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "saveChangesInTheEditor" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var s = args[0].ToCharArray();
            if (s.Length == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var result = 1;
            foreach (var c in s)
            {
                if (c >= 65 && c <= 90)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
