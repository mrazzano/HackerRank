using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{
    public class Comparator : IQuestion
    {
        private const string question = "Sorting Comparator";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "5", "amy 100", "david 100", "heraldo 50", "aakansha 75", "aleska 150" };

            solution(args);
            Console.WriteLine();
        }

        private static void solution(string[] args)
        {
            var n = Convert.ToInt32(args[0]);

            var player = new Player[n];
            var checker = new Checker();

            for (var i = 0; i < n; i++)
            {
                var tokens = args[i + 1].Split(' ');
                player[i] = new Player(tokens[0], Convert.ToInt32(tokens[1]));
            }

            Array.Sort(player, checker);
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("{0} {1}", player[i].name, player[i].score);
            }
        }

        internal class Player
        {
            public String name;
            public int score;

            public Player(String name, int score)
            {
                this.name = name;
                this.score = score;
            }
        }

        internal class Checker : IComparer<Player>
        {

            public int Compare(Player x, Player y)
            {
                if (x.score < y.score) return 1;
                if (x.score > y.score) return -1;
                
                return String.Compare(x.name, y.name, StringComparison.Ordinal);
            }
        }
    }
}
