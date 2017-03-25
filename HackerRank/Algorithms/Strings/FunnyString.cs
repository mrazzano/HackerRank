using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class FunnyString : IQuestion
    {
        private const string question = "Funny String";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "2", "acxz", "bcxz" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var s = args[i+1];

                var reverse = s.ToCharArray();
                Array.Reverse(reverse);
                var r = new string(reverse);

                var result = true;
                for (var j = 1; j < s.Length; j++)
                {
                    if (Math.Abs(s[j] - s[j - 1]) != Math.Abs(r[j] - r[j - 1]))
                    {
                        result = false;
                    }
                }

                Console.WriteLine(result ? "Funny" : "Not Funny");
            }
           
        }
    }
}
