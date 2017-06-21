using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class BirthdayChocolate : IQuestion
    {
        private const string question = "Birthday Chocolate";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "5", "1 2 1 3 2", "3 2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var s = Array.ConvertAll(args[1].Split(' '), Int32.Parse);
            
            var tokens = args[2].Split(' ');
            var d = Convert.ToInt32(tokens[0]);
            var m = Convert.ToInt32(tokens[1]);

            var result = 0;
            for (var i = 0; i < n - (m-1); i++)
            {
                var sum = 0;
                var index = i;
                for (var j = 0; j < m; j++)
                    sum += s[index++];

                if (sum == d) 
                    result++;
            }

            Console.WriteLine(result);
        }
    }
}
