using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.WarmUp
{
    public class TimeConversion : IQuestion
    {
        private const string question = "Time Conversion";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            const string args = "07:05:45PM";
            solution(args);
        }

        private static void solution(string args)
        {
            DateTime date;
            if (!DateTime.TryParse(args, out date))
            {
                throw new ArgumentException("Argument is not a date", args);
            }

            Console.WriteLine(date.ToString("HH:mm:ss"));
        }
    }
}
