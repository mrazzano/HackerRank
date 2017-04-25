using System;
using HackerRank.Algorithms.Implementation;
using HackerRank.Library;

namespace HackerRank.Algorithms.GameTheory
{
    public class MisereNim : IQuestion
    {
        private const string question = "Misere Nim";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "2", "2", "1 1", "3", "2 1 3" };
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
                var s = Array.ConvertAll(args[start + 2].Split(' '), Int32.Parse);

                var count = 0;
                var result = 0;
                for (var i = 0; i < n; i++)
                {
                    result ^= s[i];
                    if (s[i] <= 1)
                    {
                        count++;
                    }
                }

                if ((count == n && result == 1) || (count < n && result == 0))
                {
                    Console.WriteLine("Second");
                }
                else
                {
                    Console.WriteLine("First");
                }

                start += 2;
            }
        }
    }
}
