using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{

    public class StacksBalancedBrackets : IQuestion
    {
        private const string question = "Stacks: Balanced Brackets";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "3", "{[()]}", "{[(])}", "{{[[(())]]}}" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var t = Convert.ToInt32(args[0]);
            for (var i = 0; i < t; i++)
            {
                var s = args[i + 1];
                Console.WriteLine(isBalanced(s) ? "YES" : "NO");
            }
        }

        private static bool isBalanced(string s)
        {
            var stack = new Stack<char>();
            foreach (var item in s)
            {
                switch (item)
                {
                    case '{':
                    case '[':
                    case '(':
                        {
                            stack.Push(item);
                            break;
                        }
                    case '}':
                        {
                            if (stack.Count == 0 || stack.Pop() != '{')
                            {
                                return false;
                            }
                            break;
                        }
                    case ']':
                        {
                            if (stack.Count == 0 || stack.Pop() != '[')
                            {
                                return false;
                            }
                            break;
                        }
                    case ')':
                        {
                            if (stack.Count == 0 || stack.Pop() != '(')
                            {
                                return false;
                            }
                            break;
                        }
                }
            }
            return stack.Count == 0;
        }
    }
}
