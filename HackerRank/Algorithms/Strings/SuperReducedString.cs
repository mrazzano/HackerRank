using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class SuperReducedString : IQuestion
    {
        private const string question = "Super Reduced String";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] {"aaabccddd"};
            solution(args);
        }

        private static void solution(string[] args)
        {
            var s = args[0];
            for (var i = 0; i < s.Length - 1; i++)
            {
                if (s[i] != s[i + 1]) 
                    continue;

                s = s.Replace(s[i] + s[i].ToString(), "");
                i = -1;
            }
            Console.WriteLine(s == "" ? "Empty String" : s);

        }
    }
}
