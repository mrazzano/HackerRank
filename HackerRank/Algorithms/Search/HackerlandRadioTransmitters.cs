using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Search
{
    public class HackerlandRadioTransmitters : IQuestion
    {
        private const string question = "Hackerland Radio Transmitters";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "5 1", "1 2 3 4 5" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_n = args[0].Split(' ');
            var n = Convert.ToInt32(tokens_n[0]);
            var k = Convert.ToInt32(tokens_n[1]);
            var x = Array.ConvertAll(args[1].Split(' '), Int32.Parse);

            Array.Sort(x);

            int start = 0, i = 0, result = 0;
            var flag = true;

            while (i < n)
            {
                if ((x[i] - x[start]) > k)
                {
                    if (flag)
                    {
                        result++;
                        flag = false;
                        start = i - 1;
                    }
                    else
                    {
                        start = i;
                        flag = true;
                    }
                    i -= 1;
                }
                i++;
            }

            if (flag)
                result++;

            Console.WriteLine(result);
        }
    }
}
