using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.WarmUp
{
    public class VeryBigSum : IQuestion
    {
        private const string question = "A Very Big Sum";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "5", "1000000001 1000000002 1000000003 1000000004 1000000005" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var arr_temp = args[1].Split(' ');
            var arr = Array.ConvertAll(arr_temp, Int32.Parse);

            long result = 0;
            foreach (var item in arr)
            {
                result += item;
            }

            Console.WriteLine(result);
        }
    }
}
