using System;
using System.Diagnostics;
using HackerRank.Library;
using HackerRank.Algorithms;
using HackerRank.DataStructures;

namespace HackerRank
{
    class Program
    {
        static void Main()
        {
            const string header = "Solutions to HackerRank exercises.";

            // write program header
            Utility.PrintProgramHeader(header);

            // start program timer
            var timer = new Stopwatch();
            timer.Start();

            new AlgorithmModule().Execute();
            new DataStructureModule().Execute();

            // stop timer
            timer.Stop();

            // write timer output
            Console.WriteLine("Program Execution: {0}ms", timer.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
