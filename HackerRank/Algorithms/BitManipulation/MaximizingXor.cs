using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.BitManipulation
{
    public class MaximizingXOR : IQuestion
    {
        private const string question = "Maximizing XOR";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "10", "15" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var l = Convert.ToInt32(args[0]);
            var r = Convert.ToInt32(args[1]);

            var result = Int32.MinValue;
            for (var i = l; i <= r; i++)
            {
                for (var j = i; j <= r; j++)
                {
                    result = Math.Max(result, i ^ j);
                }
            }
            Console.WriteLine(result);
        }
    }
}
