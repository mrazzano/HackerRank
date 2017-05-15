using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Greedy
{
    public class LuckBalance : IQuestion
    {
        private const string question = "Luck Balance";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "6 3", "5 1", "2 1", "1 1", "8 1", "10 0", "5 0" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens = args[0].Split(' ');
            var n = Convert.ToInt32(tokens[0]);
            var k = Convert.ToInt32(tokens[1]);

            var result = 0;
            var contests = new List<int>();
            for (var i = 0; i < n; i++)
            {
                tokens = args[i + 1].Split(' ');
                var l = Convert.ToInt32(tokens[0]);
                var t = Convert.ToInt32(tokens[1]);

                if (t == 0)
                {
                    result += l;
                }
                else
                {
                    contests.Add(l);
                }
            }

            contests.Sort();
            var j = 0;
            for (var i = contests.Count - 1; i >= 0; i--)
            {
                if (j++ < k)
                {
                    result += contests[i];
                }
                else
                {
                    result -= contests[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
