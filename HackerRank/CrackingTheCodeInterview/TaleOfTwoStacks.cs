using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{
    public class TaleOfTwoStacks : IQuestion
    {
        private const string question = "Queues: A Tale of Two Stacks";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "10", "1 42", "2", "1 14", "3", "1 28", "3", "1 60", "1 78", "2", "2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var queue = new MyQueue<Int32>();
        
            var n = Convert.ToInt32(args[0]);
            for (var i = 0; i < n; i++)
            {
                var tokens = Array.ConvertAll(args[i + 1].Split(' '), Int32.Parse);
                var operation = tokens[0];
                switch (operation)
                {
                    case 1:
                        queue.enqueue(tokens[1]);
                        break;
                    case 2:
                        queue.dequeue();
                        break;
                    case 3:
                        Console.WriteLine(queue.peek());
                        break;
                }
            }
        }

        public class MyQueue<T>
        {
            readonly Stack<T> stackNewestOnTop = new Stack<T>();
            readonly Stack<T> stackOldestOnTop = new Stack<T>();

            public  void enqueue(T value)
            { 
                stackNewestOnTop.Push(value);
            }

            public T peek()
            {
                transfer();
                return stackOldestOnTop.Peek();
            }

            public T dequeue()
            {
                transfer();
                return stackOldestOnTop.Pop();
            }

            private void transfer()
            {
                if (stackOldestOnTop.Count != 0) 
                    return;

                while (stackNewestOnTop.Count > 0)
                {
                    stackOldestOnTop.Push(stackNewestOnTop.Pop());
                }
            }
        }
    }
}
