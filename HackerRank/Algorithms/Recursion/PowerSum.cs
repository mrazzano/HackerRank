using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Recursion
{
    public class PowerSum : IQuestion
    {
        private const string question = "The Power Sum";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "100", "3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var x = Convert.ToInt32(args[0]);
            var n = Convert.ToInt32(args[1]);

            var numbers = new List<int>();
            for (var i = 1; i <= x; i++)
            {
                var temp = Convert.ToInt32(Math.Pow(i, n));
                if (temp > x)
                {
                    break;
                }
                numbers.Add(temp);
            }

            Console.WriteLine(calculateSum(x, numbers.ToArray(), 0));
        }

        private static int calculateSum(int x, int[] numbers, int index)
        {
            if (x == 0)
                return 1;

            if (index >= numbers.Length)
                return 0;

          return calculateSum(x - numbers[index], numbers, index + 1) + calculateSum(x, numbers, index + 1);
        }
    }
}
