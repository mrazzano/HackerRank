using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class ViralAdvertising : IQuestion
    {
        private const string question = "Viral Advertising";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);

            var result = 0;
            var people = 5;
            for (var i = 0; i < n; i++)
            {
                result += (people / 2);
                people = people / 2 * 3;  
            }
            Console.WriteLine(result);
        }
    }
}
