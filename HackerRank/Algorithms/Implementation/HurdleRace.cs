using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class HurdleRace : IQuestion
    {
        private const string question = "Hurdle Race";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "5 4", "1 6 3 5 2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_n = args[0].Split(' ');
            var n = Convert.ToInt32(tokens_n[0]);
            var k = Convert.ToInt32(tokens_n[1]);

            var height_temp = args[1].Split(' ');
            var height = Array.ConvertAll(height_temp, Int32.Parse);

            Array.Sort(height);

            var result = 0;
            for (var i = 0; i < n; i++)
            {
                if (height[i] <= k) 
                    continue;

                k++;
                result++;
            }
            Console.WriteLine(result);
        }
    }
}
