using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting
{
    public class QuicksortInPlace : IQuestion
    {
        private const string question = "Quicksort In-Place";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "7", "5 8 1 3 7 9 2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var arr = Array.ConvertAll(args[1].Split(' '), Int32.Parse);
            quickSort(arr, 0, n - 1);
        }

        private static void quickSort(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            var pivotIndex = partition(array, left, right);
            quickSort(array, left, pivotIndex - 1);
            quickSort(array, pivotIndex + 1, right);
            printArray(array, 0, array.Length - 1);
        }

        private static int partition(int[] array, int left, int right)
        {
            var pivot = array[right];
            var i = left - 1;
            for (var j = left; j <= right - 1; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    swap(array, i, j);
                }
            }
            swap(array, i + 1, right);
            return i + 1;
        }

        private static void swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        private static void printArray(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            for (var i = left; i <= right; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
