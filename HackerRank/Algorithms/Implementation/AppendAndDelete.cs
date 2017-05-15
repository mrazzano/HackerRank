using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class AppendAndDelete : IQuestion
    {
        private const string question = "Append and Delete";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "hackerhappy", "hackerrank", "9" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var s = args[0];
            var t = args[1];
            var k = Convert.ToInt32(args[2]);

            var sLength = s.Length;
            var tLength = t.Length;
            if (sLength + tLength <= k)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                int i;
                for (i = 0; i < sLength && i < tLength; i++)
                {
                    if (s[i] != t[i])
                        break;
                }

                var minOperations = (sLength - i) + (tLength - i);
                if (k >= minOperations && (k - minOperations) % 2 == 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
