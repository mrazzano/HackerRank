using System;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Algorithms.Greedy
{
    public class PermutingTwoArrays : IQuestion
    {
        private const string question = "Permuting Two Arrays";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "2", "3 10", "2 1 3", "7 8 9", "4 5", "1 2 2 1", "3 3 3 4" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);

            var start = 0;
            var end = t * 3;
            while (start < end)
            {
                var tokens = args[start + 1].Split(' ');
                var n = Convert.ToInt32(tokens[0]);
                var k = Convert.ToInt32(tokens[1]);
                var a = Array.ConvertAll(args[start + 2].Split(' '), Int32.Parse);
                var b = Array.ConvertAll(args[start + 3].Split(' '), Int32.Parse);

                a = a.OrderBy(item => item).ToArray();
                b = b.OrderByDescending(item => item).ToArray();

                var result = true;
                for (var i = 0; i < n; i++)
                {
                    if (a[i] + b[i] < k)
                    {
                        result = false;
                        break;
                    }
                }

                Console.WriteLine(result ? "YES" : "NO");
                start += 3;
            }
        }
    }
}
