using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Search
{
    public class IceCreamParlor : IQuestion
    {
        private const string question = "Ice Cream Parlor";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "2", "4", "5", "1 4 5 3 2", "4", "4", "2 2 4 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);

            var start = 0;
            var end = t * 3;
            while (start < end)
            {
                var m = Convert.ToInt32(args[start + 1]);
                var n = Convert.ToInt32(args[start + 2]);
                var c = Array.ConvertAll(args[start + 3].Split(' '), Int32.Parse);

                for (var i = 0; i < n; i++)
                {
                    for (var j = i + 1; j < n; j++)
                    {
                        if (c[i] + c[j] == m)
                        {
                            Console.WriteLine("{0} {1}", i+1, j+1);
                        }
                    }
                }

                start += 3;
            }
        }
    }
}
