using System;
using System.Text;
using HackerRank.Library;

namespace HackerRank.Algorithms.WarmUp
{
    public class Staircase : IQuestion
    {
        private const string question = "Staircase";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            const string args = "4";
            solution(args);
        }

        private static void solution(string args)
        {
            var n = Convert.ToInt32(args);

            var sb = new StringBuilder();
            for (var i = 1; i <= n; i++)
            {
                sb.Append(new string(' ', n - i));
                sb.Append(new string('#', i));
                sb.AppendLine();
            }

            Console.Write(sb.ToString());
        }
    }
}
