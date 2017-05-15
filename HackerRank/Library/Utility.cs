using System;
using System.Text;
using System.Collections.Generic;

namespace HackerRank.Library
{
    public static class Utility
    {
        private const int LineLength = 60;    
        
        #region Output Methods

        public static void PrintProgramHeader(string header)
        {
            var separator = new string('*', LineLength);

            var sb = new StringBuilder();
            sb.AppendLine(separator);
            sb.AppendFormat("* {0}", header);
            sb.Append(Environment.NewLine);
            sb.AppendLine(separator);
            sb.AppendLine();

            Console.WriteLine(sb.ToString());
        }

        public static void PrintLessonHeader(string header)
        {
            var separator = new string('-', LineLength);

            var sb = new StringBuilder();
            sb.AppendLine(separator);
            sb.AppendLine(header);
            sb.Append(separator);

            Console.WriteLine(sb.ToString());
        }

        public static void PrintQuestionHeader(int order, string question)
        {
            const string FormatString = "Question {0} - {1}";
            Console.WriteLine(FormatString, order, question);
        }

        public static void PrintLinkedList(Node head)
        {
            var sb = new StringBuilder();
            var node = head;
            while (node != null)
            {
                sb.AppendFormat("{0}->", node.data);
                node = node.next;
            }
            Console.WriteLine(sb.ToString().Remove(sb.Length - 2, 2));
        }
        #endregion

        #region Initialization Methods

        public static Node GetLinkedList(int[] nodes)
        {
            Node lastNode = null;
            for (var i = nodes.Length - 1; i >= 0; i--)
            {
                var node = new Node(nodes[i], lastNode);
                lastNode = node;
            }
            return lastNode;
        }
        #endregion

        #region Implementation Methods

        public static void RunQuestions(string header, IReadOnlyList<IQuestion> questions)
        {
            PrintLessonHeader(header);
            for (var i = 0; i < questions.Count; i++)
            {
                questions[i].Run(i + 1);
                Console.WriteLine();
            }
        }
        #endregion
    }
}