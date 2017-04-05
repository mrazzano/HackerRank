using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Greedy
{
    public class SherlockAndTheBeast : IQuestion
    {
        private const string question = "Sherlock and the Beast";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "4", "1", "3", "5", "11" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var n = Convert.ToInt32(args[i + 1]);
                if (n < 3 || n == 4 || n == 7)
                {
                    Console.WriteLine("-1");
                }
                else if (n % 3 == 0)
                {
                    Console.WriteLine(new string('5', n));
                }
                else if (n % 3 == 2)
                {
                    Console.WriteLine(new string('5', n - 5) + new string('3', 5));
                }
                else
                {
                    Console.WriteLine(new string('5', n - 10) + new string('3', 10));
                }
            }
        }
    }
}
