using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting
{
    public class FindTheMedian : IQuestion
    {
        private const string question = "Find the Median";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "7", "0 1 2 4 6 5 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var arr = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            Array.Sort(arr);

            var middle = n / 2;
            Console.WriteLine(middle % 2 == 0 ? (arr[middle] + arr[middle + 1]) / 2 : arr[middle]);
        }
    }
}
