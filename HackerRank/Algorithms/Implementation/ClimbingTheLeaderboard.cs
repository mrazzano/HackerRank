using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class ClimbingTheLeaderboard : IQuestion
    {
        private const string question = "Climbing the Leaderboard";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "7", "100 100 50 40 40 20 10", "4", "5 25 50 120" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var scores = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var m = Convert.ToInt32(args[2]);
            var alice = Array.ConvertAll(args[3].Split(' '), Int32.Parse);

            var ranking = new List<Int32> { scores[0] };
            for (var i = 1; i < n; i++)
            {
                if (scores[i] != scores[i - 1])
                    ranking.Add(scores[i]);
            }

            var rank = ranking.Count;
            for (var i = 0; i < m; i++)
            {
                var score = alice[i];
                while (rank > 0 && score >= ranking[rank - 1])
                    rank--;

                Console.WriteLine(rank + 1);
            }
        }
    }
}
