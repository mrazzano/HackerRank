using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.WarmUp
{
    public class SimpleArraySum : IQuestion
    {
        private const string question = "Simple Array Sum";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "6", "1 2 3 4 10 11" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var arr_temp = args[1].Split(' ');
            var arr = Array.ConvertAll(arr_temp, Int32.Parse);

            var result = 0;
            foreach (var item in arr)
            {
                result += item;
            }

            Console.WriteLine(result);
        }
    }
}
