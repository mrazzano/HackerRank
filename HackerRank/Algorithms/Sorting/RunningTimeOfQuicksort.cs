using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting
{
    public class RunningTimeOfQuicksort : IQuestion
    {
        private const string question = "Running Time of Quicksort";

        private static int swaps;
        private static int shifts;

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "7", "1 3 9 8 2 7 5" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var arr = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var array1 = (int[])arr.Clone();
            var array2 = (int[])arr.Clone();

            insertionSortShifts(array1);
            quickSort(array2, 0, n - 1);

            Console.WriteLine(shifts - swaps);
        }

        public static void insertionSortShifts(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var j = i;
                var value = array[i];
                while (j >= 1 && array[j - 1] > value)
                {
                    array[j] = array[j - 1];
                    j--;
                    shifts++;
                }
                array[j] = value;
            }
        }

        private static void quickSort(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            var pivotIndex = partition(array, left, right);
            quickSort(array, left, pivotIndex - 1);
            quickSort(array, pivotIndex + 1, right);
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
            swaps++;
        }
    }
}
