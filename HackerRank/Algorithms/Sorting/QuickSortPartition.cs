using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting
{
    public class QuicksortPartition : IQuestion
    {
        private const string question = "Quicksort 1 - Partition";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "5", "4 5 3 7 2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var arr = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var pivot = arr[0];
            var left = new List<int>();
            var right = new List<int>();
            var equal = new List<int> { pivot };

            for (var i = 1; i < n; i++)
            {
                if (arr[i] < pivot)
                {
                    left.Add(arr[i]);
                }
                else if (arr[i] > pivot)
                {
                    right.Add(arr[i]);
                }
                else
                {
                    equal.Add(arr[i]);
                }
            }

            left.ForEach(item => Console.Write("{0} ", item));
            equal.ForEach(item => Console.Write("{0} ", item));
            right.ForEach(item => Console.Write("{0} ", item));

            Console.WriteLine();
        }
    }
}
