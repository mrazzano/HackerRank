using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting
{
    public class BigSorting : IQuestion
    {
        private const string question = "Big Sorting";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "6", "31415926535897932384626433832795", "1", "3", "10", "3", "5" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var arr = new string[n];
            for (var i = 0; i < n; i++)
            {
                arr[i] = args[i + 1];
            }

            Array.Sort(arr, new CustomComparer());
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        internal class CustomComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                if (x.Length != y.Length) return x.Length - y.Length;

                for (var i = 0; i < x.Length; i++)
                {
                    var left = x[i];
                    var right = y[i];
                    if (left != right)
                        return left - right;
                }

                return 0;
            }
        }
    }
}
