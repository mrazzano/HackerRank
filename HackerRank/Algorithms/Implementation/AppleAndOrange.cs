using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class AppleAndOrange : IQuestion
    {
        private const string question = "Apple and Orange";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "7 11", "5 15", "3 2", "-2 2 1", "5 -6" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_s = args[0].Split(' ');
            var s = Convert.ToInt32(tokens_s[0]);
            var t = Convert.ToInt32(tokens_s[1]);

            var tokens_a = args[1].Split(' ');
            var a = Convert.ToInt32(tokens_a[0]);
            var b = Convert.ToInt32(tokens_a[1]);

            var apple = Array.ConvertAll(args[3].Split(' '), Int32.Parse);
            var orange = Array.ConvertAll(args[4].Split(' '), Int32.Parse);

            var appleCount = 0;
            var orangeCount = 0;

            foreach (var item in apple)
            {
                var location = a + item;
                if (location >= s && location <= t)
                    appleCount++;
            }

            foreach (var item in orange)
            {
                var location = b + item;
                if (location >= s && location <= t)
                    orangeCount++;
            }

            Console.WriteLine("{0} {1}", appleCount, orangeCount);
        }
    }
}
