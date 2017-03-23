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
            for (var a0 = 0; a0 < t; a0++)
            {
                var tokens_n = args[a0+1].Split(' ');
                var n = Convert.ToInt32(tokens_n[0]);
                var k = Convert.ToInt32(tokens_n[1]);
                var a_temp = args[a0+2].Split(' ');
                var a = Array.ConvertAll(a_temp, Int32.Parse);

                var count = 0;
                for (var i = 0; i < n; i++)
                {
                    if (a[i] <= 0)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count >= k ? "NO" : "YES");
            }
        }
    }
}
