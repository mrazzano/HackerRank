using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class ACMICPCTeam : IQuestion
    {
        private const string question = "ACM ICPC Team";

        public void Run(int order)
        {
            Console.WriteLine("Question {0} - {1}", order, question);

            var args = new[] { "4 5", "10101", "11100", "11010", "00101" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens_n = args[0].Split(' ');
            var n = Convert.ToInt32(tokens_n[0]);
            var m = Convert.ToInt32(tokens_n[1]);
            
            var topic = new string[n];
            for (var i = 0; i < n; i++)
            {
                topic[i] = args[i+1];
            }

            var teams = 0;
            var maxTopics = 0;
            for (var i = 0; i < n - 1; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    var temp = 0;
                    for (var k = 0; k < m; k++)
                    {
                        if (topic[i][k] == '1' || topic[j][k] == '1')
                        {
                            temp++;
                        }
                    }
                    if (temp > maxTopics)
                    {
                        maxTopics = temp;
                        teams = 1;
                    }
                    else if (temp == maxTopics)
                        teams++;
                }
            }

            Console.WriteLine(maxTopics);
            Console.WriteLine(teams);
        }
    }
}
