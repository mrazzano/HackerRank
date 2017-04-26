using System;
using System.Text;
using System.Collections.Generic;


namespace HackerRank.Library
{
    public static class Utility
    {
        private const int LineLength = 60;

        public static string GetProgramHeader(string header)
        {
            var separator = new string('*', LineLength);

            var sb = new StringBuilder();
            sb.AppendLine(separator);
            sb.AppendFormat("* {0}", header);
            sb.Append(Environment.NewLine);
            sb.AppendLine(separator);
            sb.AppendLine();

            return sb.ToString();
        }

        public static string GetLessonHeader(string header)
        {
            var separator = new string('-', LineLength);

            var sb = new StringBuilder();
            sb.AppendLine(separator);
            sb.AppendLine(header);
            sb.Append(separator);

            return sb.ToString();
        }

        public static void RunQuestions(string header, IReadOnlyList<IQuestion> questions)
        {
            Console.WriteLine(GetLessonHeader(header));
            for (var i = 0; i < questions.Count; i++)
            {
                questions[i].Run(i + 1);
                Console.WriteLine();
            }
        }
    }
}