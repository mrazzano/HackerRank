using System;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{
    public class Primality : IQuestion
    {
        private const string question = "Time Complexity: Primality";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "12", "5", "7" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var p = Convert.ToInt32(args[0]);
            for (var i=0; i < p; i++)
            {
                var n = Convert.ToInt32(args[i + 1]);
                Console.WriteLine(isPrime(n) ? "Prime" : "Not prime");
            }
        }

        private static bool isPrime(int n)
        {
            if (n < 2) 
                return false;

            var sqrt = Math.Sqrt(n);
            for (var i = 2; i <= sqrt; i++)
            {
                if (n%i == 0)
                    return false;
            }
            return true;
        }
    }
}
