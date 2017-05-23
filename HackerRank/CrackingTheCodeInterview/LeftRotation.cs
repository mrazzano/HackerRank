using System;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{

    public class LeftRotation : IQuestion
    {
        private const string question = "Left Rotation";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "5 4", "1 2 3 4 5" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens = Array.ConvertAll(args[0].Split(' '), Int32.Parse);
            var n = tokens[0];
            var k = tokens[1];

            var array = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var result = new int[n];
            for (var i = 0; i < n; i++)
            {
                result[(i + n - k) % n] = array[i];
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
