using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class JumpingOnTheCloudsRevisited : IQuestion
    {
        private const string question = "Jumping on the Clouds: Revisited";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "8 2", "0 0 1 0 0 1 1 0" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_n = args[0].Split(' ');
            var n = Convert.ToInt32(tokens_n[0]);
            var k = Convert.ToInt32(tokens_n[1]);
            var c = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var result = 100;
            for (var i = 0; i < n; i += k)
            {
                result--;
                if (c[i] == 1)
                {
                    result -= 2;
                }
            }
            Console.WriteLine(result);
        }
    }
}
