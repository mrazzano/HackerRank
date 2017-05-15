using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class TwoCharacters : IQuestion
    {
        private const string question = "Two Characters";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "10", "beabeefeab" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            const int Letter_Count = 26;

            var n = Convert.ToInt32(args[0]);
            var s = args[1];

            if (n <= 1)
            {
                Console.WriteLine(0);
                return;
            }

            var pair = new int[Letter_Count, Letter_Count];
            var count = new int[Letter_Count, Letter_Count];
            for (var i = 0; i < n; i++)
            {
                var letter = s[i];
                var number = letter - 'a';
                for (var col = 0; col < Letter_Count; col++)
                {
                    if (pair[number, col] == letter)
                    {
                        count[number, col] = -1;
                    }
                    if (count[number, col] != -1)
                    {
                        pair[number, col] = letter;
                        count[number, col]++;
                    }
                }

                for (var row = 0; row < Letter_Count; row++)
                {
                    if (pair[row, number] == letter)
                    {
                        count[row, number] = -1;
                    }
                    if (count[row, number] != -1)
                    {
                        pair[row, number] = letter;
                        count[row, number]++;
                    }
                }
            }

            var result = 0;
            for (var row = 0; row < Letter_Count; row++)
            {
                for (var col = 0; col < Letter_Count; col++)
                {
                    result = Math.Max(result, count[row, col]);
                }
            }
            Console.WriteLine(result);
        }
    }
}