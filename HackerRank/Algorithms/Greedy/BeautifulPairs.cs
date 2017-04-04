using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Greedy
{
    public class BeautifulPairs : IQuestion
    {
        private const string question = "Beautiful Pairs";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "3", "1 2 2", "1 2 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            const int Max = 1000;

            var n = Convert.ToInt32(args[0]);
            var a = Array.ConvertAll(args[1].Split(' '), Int32.Parse);
            var b = Array.ConvertAll(args[2].Split(' '), Int32.Parse);

            var result = 0;
            var hash = new int[Max+1];
            for (var i = 0; i < n; i++)
            {
                hash[a[i]]++;
            }

            for (var i = 0; i < n; i++)
            {
                if (hash[b[i]] > 0)
                {
                    hash[b[i]]--;
                    result++;
                }
            }

            result = result == n ? result - 1 : result + 1;
            Console.WriteLine(result);
        }
    }
}
