using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class BonAppetit : IQuestion
    {
        private const string question = "Bon Appetit";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "4 1", "3 10 2 9", "12" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_n = args[0].Split(' ');
            var n = Convert.ToInt32(tokens_n[0]);
            var k = Convert.ToInt32(tokens_n[1]);
            var c = Array.ConvertAll(args[1].Split(' '), Int32.Parse);
            
            var charged = Convert.ToInt32(args[2]);

            var sum = 0;
            for (var i = 0; i < n; i++)
            {
                if (i != k)
                {
                    sum += c[i];
                }
            }

            var cost = sum/2;
            Console.WriteLine(cost == charged ? "Bon Appetit" : (charged - cost).ToString());
        }
    }
}
