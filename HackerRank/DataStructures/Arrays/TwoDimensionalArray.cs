using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.Arrays
{
    public class TwoDimensionalArray : IQuestion
    {
        private const string question = "2D Array DS";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "1 1 1 0 0 0", "0 1 0 0 0 0", "1 1 1 0 0 0", "0 0 2 4 4 0", "0 0 0 2 0 0", "0 0 1 2 4 0" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var arr = new int[6][];
            for (var i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(args[i].Split(' '), Int32.Parse);
            }

            var result = Int32.MinValue;
            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    var sum1 = arr[i][j] + arr[i][j + 1] + arr[i][j + 2];
                    var sum2 = arr[i + 1][j + 1];
                    var sum3 = arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    result = Math.Max(result, sum1 + sum2 + sum3);
                }
            }
            Console.WriteLine(result);
        }
    }
}
