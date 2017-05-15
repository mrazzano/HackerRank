using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class GradingStudents : IQuestion
    {
        private const string question = "Grading Students";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "4", "73", "67", "40", "33" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            
            var grades = new int[n];
            for (var i = 0; i < n; i++)
            {
                grades[i] = Convert.ToInt32(args[i + 1]);
            }

            foreach (var item in grades)
            {
                if (item < 38)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    var next = item + (5 - item % 5);
                    Console.WriteLine(next - item < 3 ? next : item);
                }
            }
        }
    }
}
