using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Greedy
{
    public class LargestPermutation : IQuestion
    {
        private const string question = "Largest Permutation";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "5 1", "4 2 3 5 1" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens = args[0].Split(' ');
            var n = Convert.ToInt32(tokens[0]);
            var k = Convert.ToInt32(tokens[1]);
            var a = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var index = new int[n + 1];
            for (var i = 0; i < n; i++)
            {
                index[a[i]] = i;
            }

            for (var i = 0; i < n && k > 0; i++)
            {
                if (a[i] != n - i)
                {
                    a[index[n - i]] = a[i];
                    index[a[i]] = index[n - i];
                    a[i] = n - i;
                    index[n - i] = i;
                    k--; 
                }
            }

            Console.WriteLine(string.Join(" ", a));
        }
    }
}
