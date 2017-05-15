using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting
{
    public class ClosestNumbers : IQuestion
    {
        private const string question = "Closest Numbers";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "10", "-20 -3916237 -357920 -3620601 7374819 -7330761 30 6246457 -6461594 266854" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var arr = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            Array.Sort(arr);

            var list = new List<int>();
            var min = Int32.MaxValue;
            for (var i = 1; i < n; i++)
            {
                var difference = arr[i] - arr[i - 1];
                if (difference <= min)
                {
                    if (difference < min)
                    {
                        min = difference;
                        list.Clear();
                    }

                    list.Add(arr[i - 1]);
                    list.Add(arr[i]);
                }
            }
            list.ForEach(item=>Console.Write("{0} ", item));
            Console.WriteLine();
        }
    }
}
