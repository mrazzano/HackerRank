using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class Anagram : IQuestion
    {
        private const string question = "Anagram";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "6", "aaabbb", "ab", "abc", "mnop", "xyyx", "xaxbbbxx" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            for (var i = 0; i < n; i++)
            {
                var s = args[i + 1];
                var s1 = s.Substring(0, s.Length / 2);
                var s2 = s.Substring(s.Length / 2);

                if (s1.Length == s2.Length)
                {
                    foreach (var c in s1)
                    {
                        var index = s2.IndexOf(c);
                        if (index >= 0)
                        {
                            s2 = s2.Remove(index, 1);
                        }
                    }
                    Console.WriteLine(s2.Length);
                }
                else
                {
                    Console.WriteLine(-1);

                }
            }
        }
    }
}
