using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class CavityMap : IQuestion
    {
        private const string question = "Cavity Map";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "4", "1112", "1912", "1892", "1234" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var grid = new char[n][];

            for (var i = 0; i < n; i++)
            {
                grid[i] = args[i + 1].ToCharArray();
            }

            for (var i = 1; i < n - 1; i++)
            {
                for (var j = 1; j < n - 1; j++)
                {
                    int d = grid[i][j];
                    if (d > grid[i][j - 1] && d > grid[i][j + 1] && d > grid[i - 1][j] && d > grid[i + 1][j])
                    {
                        grid[i][j] = 'X';
                    }
                }
            }

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    Console.Write(grid[i][j]);
                }

                Console.WriteLine();
            }
        }
    }
}
