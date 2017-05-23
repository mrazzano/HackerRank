using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{

    public class RansomNote : IQuestion
    {
        private const string question = "Ransom Note";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "6 4", "give me one grand today night", "give one grand today" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens = Array.ConvertAll(args[0].Split(' '), Int32.Parse);
            var m = Convert.ToInt32(tokens[0]);
            var n = Convert.ToInt32(tokens[1]);
            var magazine = args[1].Split(' ');
            var ransom = args[2].Split(' ');

            var dict = new Dictionary<string, int>();
            for (var i = 0; i < m; i++)
            {
                var word = magazine[i];
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }

            var result = true;
            for (var i = 0; i < n; i++)
            {
                var word = ransom[i];
                if (!dict.ContainsKey(word) || dict[word] <= 0)
                {
                    result = false;
                    break;

                }
                dict[word]--;
            }
            Console.WriteLine("{0}", result ? "Yes" : "No");
        }
    }
}
