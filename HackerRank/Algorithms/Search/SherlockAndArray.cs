using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Search
{
    public class SherlockAndArray : IQuestion
    {
        private const string question = "Sherlock and Array";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "2", "3", "1 2 3", "4", "1 2 3 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            
            var start = 0;
            var end = t * 2;
            while (start < end)
            {
                var n = Convert.ToInt32(args[start + 1]);
                var a = Array.ConvertAll(args[start + 2].Split(' '), Int32.Parse);

                var result = false;
                int total = 0, sum = 0;
                for (var i = 0; i < n; i++)
                {
                    total += a[i];
                }

                for (var i = 0; i < n; i++)
                {
                    if (sum == total - sum - a[i])
                    {
                        result = true;
                        break;
                    }
                    sum += a[i];
                }

                Console.WriteLine(result ? "YES" : "NO");
                start += 2;
            }
        }
    }
}
