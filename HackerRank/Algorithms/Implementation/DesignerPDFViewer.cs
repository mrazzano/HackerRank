using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class DesignerPDFViewer : IQuestion
    {
        private const string question = "Designer PDF Viewer";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5", "abc" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var h_temp = args[0].Split(' ');
            var h = Array.ConvertAll(h_temp, Int32.Parse);

            var word = args[1];

            var table = new Dictionary<char, int>();
            for (var i = 0; i < h.Length; i++)
            {
                table.Add((char)(i + 97), h[i]);
            }

            var max = 0;
            foreach (var item in word)
            {
                max = Math.Max(max, table[item]);
            }

            Console.WriteLine(word.Length * 1 * max);
        }
    }
}
