using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.Arrays
{
    public class LeftRotation : IQuestion
    {
        private const string question = "Left Rotation";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "5 4", "1 2 3 4 5" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens = args[0].Split(' ');
            var n = Convert.ToInt32(tokens[0]);
            var d = Convert.ToInt32(tokens[1]);
            var arr = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var result = new int[n];
            for (var i = 0; i < n; i++)
            {
                result[(i + n - d)%n] = arr[i];
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
