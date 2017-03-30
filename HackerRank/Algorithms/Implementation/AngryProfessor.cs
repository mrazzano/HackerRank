using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class AngryProfessor : IQuestion
    {
        private const string question = "Angry Professor";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "2", "4 3", "-1 -3 4 2", "4 2", "0 -1 2 1" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var tokens_n = args[i+1].Split(' ');
                var n = Convert.ToInt32(tokens_n[0]);
                var k = Convert.ToInt32(tokens_n[1]);
                var a = Array.ConvertAll(args[i+2].Split(' '), Int32.Parse);

                var count = 0;
                for (var j = 0; j < n; j++)
                {
                    if (a[j] <= 0)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count >= k ? "NO" : "YES");
            }
        }
    }
}
