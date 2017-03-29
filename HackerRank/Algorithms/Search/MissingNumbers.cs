using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Search
{
    public class MissingNumbers : IQuestion
    {
        private const string question = "Missing Numbers";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "10", "203 204 205 206 207 208 203 204 205 206", "13", "203 204 204 205 206 207 205 208 203 206 205 206 204" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var a = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var m = Convert.ToInt32(args[2]);
            var b = Array.ConvertAll(args[3].Split(' '), Int32.Parse);

            Array.Sort(a);
            Array.Sort(b);

            var result = new List<int>();
            int i = 0, j = 0;

            while (i < n)
            {
                if (a[i] == b[j])
                {
                    i++;
                }
                else
                {
                    if (!result.Contains(b[j]))
                    {
                        result.Add(b[j]);
                    }
                }
                j++;
            }

            while (j < m)
            {
                if (!result.Contains(b[j]))
                {
                    result.Add(b[j]);
                }
                j++;
            }
            result.ForEach(item => Console.Write("{0} ", item));
            Console.WriteLine();
        }
    }
}
