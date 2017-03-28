using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting
{
    public class InsertionSortPart1 : IQuestion
    {
        private const string question = "Insertion Sort - Part 1";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "2 4 6 8 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var arr = Array.ConvertAll(args[0].Split(' '), Int32.Parse);

            var position = arr.Length - 1;
            var value = arr[position];
            while (position > 0 && arr[position - 1] > value)
            {
                arr[position] = arr[position - 1];
                position--;

                Console.WriteLine(string.Join(" ", arr));
            }
            arr[position] = value;
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
