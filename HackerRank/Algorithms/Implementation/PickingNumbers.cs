using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class PickingNumbers : IQuestion
    {
        private const string question = "Picking Numbers";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "6", "4 6 5 3 3 1" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var a = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var map = new int[100];
            for(var i=0; i<n; i++)
                map[a[i]]++;

            var result = 0;
            for (var i = 1; i < map.Length; i++)
            {
                var count = map[i] + map[i - 1];
                result = Math.Max(result, count);
            }

            Console.WriteLine(result);
        }
    }
}
