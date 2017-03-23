using System;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class BetweenTwoSets : IQuestion
    {
        private const string question = "Between Two Sets";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] {"2 3", "2 4", "16 32 96"};
            solution(args);
        }

        private static void solution(string[] args)
        {
            var a_temp = args[1].Split(' ');
            var a = Array.ConvertAll(a_temp, Int32.Parse);

            var b_temp = args[2].Split(' ');
            var b = Array.ConvertAll(b_temp, Int32.Parse);

            var multiple = a.Aggregate(lcm);
            var divisor = b.Aggregate(gcd);

            Console.WriteLine(Enumerable.Range(1, divisor / multiple).Count(i => divisor % (multiple * i) == 0));
        }

        static int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }

        static int lcm(int a, int b)
        {
            var k = gcd(a, b);
            a /= k;
            return a * b;
        }
    }
}
