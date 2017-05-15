using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting
{
    public class InsertionSortPart2 : IQuestion
    {
        private const string question = "Insertion Sort - Part 2";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "6", "1 4 3 5 6 2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var arr = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            for (var i = 1; i < n; i++)
            {
                var position = i;
                var value = arr[position];
                while (position > 0 && arr[position - 1] > value)
                {
                    arr[position] = arr[position - 1];
                    position--;
                }
                arr[position] = value;
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
