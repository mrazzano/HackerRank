using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class RepeatedString : IQuestion
    {
        private const string question = "Repeated String";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "aba", "10" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var s = args[0];
            var n = Convert.ToInt64(args[1]);

            var length = s.Length;
            var words = n / length;
            var remainder = n % length;

            long result = 0;
            for (var i = 0; i < length; i++)
            {
                if (s[i] != 'a') 
                    continue;

                result += words;

                if (i < remainder)
                    result++;
            }
            Console.WriteLine(result);
        }
    }
}
