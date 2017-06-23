using System;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{
    public class CoinChange : IQuestion
    {
        private const string question = "DP: Coin Change";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "4 3", "1 2 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens = args[0].Split(' ');
            var n = Convert.ToInt32(tokens[0]);
            var coins = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            Console.WriteLine(coinChange(coins, n));
        }

        private static long coinChange(int[] coins, int money)
        {
            var dp = new long[money + 1];
            dp[0] = 1;
            foreach (var coin in coins)
            {
                for (var i = coin; i < dp.Length; i++)
                    dp[i] += dp[i - coin];
            }
            return dp[money];
        }
    }
}
