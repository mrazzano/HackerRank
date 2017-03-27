using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class Gemstones : IQuestion
    {
        private const string question = "Gemstones";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "3", "abcdde", "baccd", "eeabg" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);

            var map = new int[26, t];
            for (var i = 0; i < t; i++)
            {
                var s = args[i + 1];

                foreach (var item in s)
                {
                    map[item - 97, i] = 1;
                }
            }

            var result = 26;
            var rows = map.GetLength(0);
            var cols = map.GetLength(1);
            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < cols; j++)
                {
                    if (map[i, j] != 1)
                    {
                        result--;
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
