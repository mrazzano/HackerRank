using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class FlatlandSpaceStations : IQuestion
    {
        private const string question = "Flatland Space Stations";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "5 2", "0 4" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_n = args[0].Split(' ');
            var n = Convert.ToInt32(tokens_n[0]);
            var m = Convert.ToInt32(tokens_n[1]);
            var c = Array.ConvertAll(args[1].Split(), Int32.Parse);

            Array.Sort(c);
            var maxDistance = c[0];
            for (var i = 1; i < m; i++)
            {
                var distance = (c[i] - c[i - 1]) / 2;
                if (maxDistance < distance)
                    maxDistance = distance;
            }

            var lastGap = (n - 1) - c[m - 1];
            Console.WriteLine(lastGap < maxDistance ? maxDistance : lastGap);
        }
    }
}
