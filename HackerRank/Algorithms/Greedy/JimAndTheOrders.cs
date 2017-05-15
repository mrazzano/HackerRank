using System;
using System.Linq;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Greedy
{
    public class JimAndTheOrders : IQuestion
    {
        private const string question = "Jim and the Orders";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "1 3", "2 3", "3 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);

            var hash = new Dictionary<int, int>();
            for (var i = 0; i < n; i++)
            {
                var tokens = args[i + 1].Split(' ');
                var t = Convert.ToInt32(tokens[0]);
                var d = Convert.ToInt32(tokens[1]);

                hash.Add(i + 1, t+d);
            }

            foreach (var item in hash.OrderBy(p => p.Value))
            {
                Console.Write(item.Key + " ");
            }
            Console.WriteLine();
        }
    }
}
