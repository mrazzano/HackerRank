using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    public class CaeserCipher : IQuestion
    {
        private const string question = "Caeser Cipher";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "11", "middle-Outz", "2" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);
            var s = args[1];
            var k = Convert.ToInt32(args[2]);

            var message = s.ToCharArray();
            for (var i = 0; i < n; i++)
            {
                if (!Char.IsLetter(message[i])) 
                    continue;

                var baseChar = Char.IsLower(message[i]) ? 'a' : 'A';
                message[i] = (char)((message[i] - baseChar + k) % 26 + baseChar);
            }
            Console.WriteLine(new string(message));
        }
    }
}
