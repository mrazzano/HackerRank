using System;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{

    public class MakingAnagrams : IQuestion
    {
        private const string question = "Making Anagrams";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "abc", "cde" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var a = args[0];
            var b = args[1];

            var counts = new int[26];
            foreach (var item in a)
            {
                counts[item - 'a']++;
            }

            foreach (var item in b)
            {
                counts[item - 'a']--;
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
