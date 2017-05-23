using System;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{

    public class SortingBubbleSort : IQuestion
    {
        private const string question = "Sorting: Bubble Sort";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "1 2 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var array = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            Console.WriteLine("Array is sorted in {0} swaps.", sort(array, n));
            Console.WriteLine("First Element: {0}", array[0]);
            Console.WriteLine("Last Element: {0}", array[n - 1]);
        }

        private static int sort(int[] array, int n)
        {
            var numberOfSwaps = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n - 1; j++)
                {
                    if (array[j] <= array[j + 1])
                        continue;

                    swap(array, j, j + 1);
                    numberOfSwaps++;
                }

                if (numberOfSwaps == 0)
                {
                    break;
                }
            }
            return numberOfSwaps;
        }

        private static void swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
