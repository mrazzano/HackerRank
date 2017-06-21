using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class CountingValleys : IQuestion
    {
        private const string question = "Counting Valleys";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "8", "UDDDUDUU" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var s = args[1];

            var result = 0;
            var seaLevel = 0;
            var inValley = false;
            for(var i=0; i<n; i++)
            {
                seaLevel = s[i] == 'U' ? seaLevel+1 : seaLevel-1;
                if (seaLevel < 0 && inValley == false)
                {
                    inValley = true;
                    result++;
                }

                if (seaLevel >= 0)
                    inValley = false;
            }
            Console.WriteLine(result);
        }
    }
}
