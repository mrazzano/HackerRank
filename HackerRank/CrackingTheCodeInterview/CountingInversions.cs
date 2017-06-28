using System;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{
    public class CountingInversions : IQuestion
    {
        private const string question = "Merge Sort: Counting Inversions";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "2", "5", "1 1 1 2 2", "5", "2 1 3 1 2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t * 2; i += 2)
            {
                var arr = Array.ConvertAll(args[i + 2].Split(' '), Int32.Parse);
                Console.WriteLine(countInversions(arr));
            }
        }

        private static long countInversions(int[] arr)
        {
            var aux = (int[]) arr.Clone();
            return countInversions(arr, 0, arr.Length - 1, aux);
        }

        private static long countInversions(int[] arr, int lo, int hi, int[] aux)
        {
            if (lo >= hi) return 0;

            var mid = lo + (hi - lo) / 2;

            long count = 0;
            count += countInversions(aux, lo, mid, arr);
            count += countInversions(aux, mid + 1, hi, arr);
            count += merge(arr, lo, mid, hi, aux);

            return count;
        }

        private static long merge(int[] arr, int lo, int mid, int hi, int[] aux)
        {
            long count = 0;
            int i = lo, j = mid + 1, k = lo;
            while (i <= mid || j <= hi)
            {
                if (i > mid)
                {
                    arr[k++] = aux[j++];
                }
                else if (j > hi)
                {
                    arr[k++] = aux[i++];
                }
                else if (aux[i] <= aux[j])
                {
                    arr[k++] = aux[i++];
                }
                else
                {
                    arr[k++] = aux[j++];
                    count += mid + 1 - i;
                }
            }

            return count;
        }
    }
}
