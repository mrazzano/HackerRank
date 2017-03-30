using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.WarmUp
{
    public class MinMaxSum : IQuestion
    {
        private const string question = "Min Max Sum";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "1 2 3 4 5" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Array.ConvertAll(args[0].Split(' '), Int32.Parse);
            var length = n.Length;

            Array.Sort(n);

            long sum = 0;
            long min = n[0];
            long max = n[length - 1];
            for (var i = 0; i < length; i++)
            {
                sum += n[i];
            }

            Console.WriteLine("{0} {1}", sum - max, sum - min );
        }
    }
}
