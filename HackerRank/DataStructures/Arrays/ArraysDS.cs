using System;
using System.Text;
using HackerRank.Library;

namespace HackerRank.DataStructures.Arrays
{
    public class ArraysDS : IQuestion
    {
        private const string question = "Arrays DS";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "4", "1 4 3 2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var arr = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var result = new StringBuilder();
            for (var i = n - 1; i >= 0; i--)
            {
                result.AppendFormat("{0} ", arr[i]);
            }

            Console.WriteLine(result.ToString().Remove(result.Length - 1, 1));
        }
    }
}
