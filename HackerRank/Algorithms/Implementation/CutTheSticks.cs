using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class CutTheSticks : IQuestion
    {
        private const string question = "Cut the Sticks";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "6", "5 4 4 2 2 8" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var arr = Array.ConvertAll(args[1].Split(' '), Int32.Parse);
            
            var list = new List<int>(arr);
            list.Sort();

            Console.WriteLine(list.Count);

            while (list.Count > 1)
            {
                if (list[0] == list[1])
                {
                    list.RemoveAt(0);
                }
                else
                {
                    for (var i = 1; i < list.Count; i++)
                    {
                        list[i-1] -= list[0];
                    }
                    list.RemoveAt(0);   
                    Console.WriteLine(list.Count);
                }
            }
        }
    }
}
