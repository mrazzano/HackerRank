using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class CatsAndMouse : IQuestion
    {
        private const string question = "Cats and Mouse";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "1 2 3", "1 3 2", "2 1 3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var q = Convert.ToInt32(args[0]);
            for (var i = 0; i < q; i++)
            {
                var tokens = args[i+1].Split(' ');
                var x = Convert.ToInt32(tokens[0]);
                var y = Convert.ToInt32(tokens[1]);
                var z = Convert.ToInt32(tokens[2]);

                var distanceCatA = Math.Abs(z - x);
                var distanceCatB = Math.Abs(z - y);
                if (distanceCatA < distanceCatB)
                {
                    Console.WriteLine("Cat A");
                }
                else if (distanceCatB < distanceCatA)
                {
                    Console.WriteLine("Cat B");
                }
                else
                {
                    Console.WriteLine("Mouse C");
                }
            }
        }
    }
}
