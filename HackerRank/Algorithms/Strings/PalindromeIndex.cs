using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class PalindromeIndex : IQuestion
    {
        private const string question = "Palindrome Index";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "aaab", "baa", "aaa" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(findPalindromeIndex(args[i + 1]));
            }
        }

        private static int findPalindromeIndex(string s)
        {
            var start = 0;
            var end = s.Length - 1;
            while (start <= end)
            {
                if (s[start] != s[end])
                {
                    if (s[start + 1] == s[end] && s[start + 2] == s[end - 1])
                    {
                        return start;
                    }

                    if (s[start] == s[end - 1] && s[start + 1] == s[end - 2])
                    {
                        return end;
                    }
                }
                start++;
                end--;
            }
            return -1;
        }
    }
}
