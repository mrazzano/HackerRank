using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting
{
    public class QuicksortSorting : IQuestion
    {
        private const string question = "Quicksort 2 - Sorting";

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
            printArray(array, left, right);
        }

        private static int partition(int[] array, int left, int right)
        {
            var pivot = array[left];
            var leftList = new List<int>();
            var rightList = new List<int>();

            for (var i = left + 1; i <= right; i++)
            {
                if (array[i] < pivot)
                {
                    leftList.Add(array[i]);
                }
                else
                {
                    rightList.Add(array[i]);
                }
            }

            var index = left;
            foreach (var item in leftList)
            {
                array[index] = item;
                index++;
            }

            var newPivotIndex = left + leftList.Count;
            array[newPivotIndex] = pivot;
            index = newPivotIndex + 1;

            foreach (var item in rightList)
            {
                array[index] = item;
                index++;
            }

            return newPivotIndex;
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
