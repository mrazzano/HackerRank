using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class MakingAnagrams : IQuestion
    {
        private const string question = "Making Anagrams";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "cde", "abc" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var s1 = args[0];
            var s2 = args[1];

            var counts = new int[26];
            foreach (var c in s1)
            {
                counts[c - 'a']++;
            }

            foreach (var c in s2)
            {
                counts[c - 'a']--;
            }

            var result = 0;
            for (var i = 0; i < 26; i++)
            {
                result += Math.Abs(counts[i]);
            }
            Console.WriteLine(result);
        }
    }
}
