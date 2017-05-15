using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting
{
    public class RunningTimeOfInsertionSort : IQuestion
    {
        private const string question = "Running Time of Algorithms";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "5", "2 1 3 1 2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var arr = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            var result = 0;
            for (var i = 1; i < n; i++)
            {
                var position = i;
                var value = arr[position];
                while (position > 0 && arr[position - 1] > value)
                {
                    arr[position] = arr[position - 1];
                    position--;
                    result++;
                }
                arr[position] = value;
              
            }
            Console.WriteLine(result);
        }
    }
}
