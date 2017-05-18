using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.DataStructures.Stacks
{
    public class StackMaximumElement : IQuestion
    {
        private const string question = "Maximum Element";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "10", "1 97", "2", "1 20", "2", "1 26", "1 20", "2", "3", "1 91", "3" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var max = Int32.MinValue;
            var stack = new Stack<StackNode>();

            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var arr = Array.ConvertAll(args[i + 1].Split(' '), Int32.Parse);
                var operation = arr[0];

                switch (operation)
                {
                    case 1:
                        {
                            var value = arr[1];
                            max = Math.Max(max, value);
                            stack.Push(new StackNode(value, max));
                            break;
                        }
                    case 2:
                        {
                            if (stack.Count > 0)
                            {
                                stack.Pop();
                            }
                            max = stack.Count == 0 ? Int32.MinValue : stack.Peek().max;
                            break;
                        }
                    case 3:
                        {
                            if (stack.Count > 0)
                            {
                                Console.WriteLine(stack.Peek().max);
                            }
                            break;
                        }
                }
            }
        }

        public class StackNode
        {
            public int max;
            public int data;

            public StackNode(int data, int max)
            {
                this.data = data;
                this.max = max;
            }
        }
    }
}
