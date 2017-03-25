using System;
using System.Diagnostics;
using HackerRank.Library;
using System.Collections.Generic;
using HackerRank.Algorithms.WarmUp;
using HackerRank.Algorithms.Implementation;
using HackerRank.Algorithms.Strings;

namespace HackerRank
{
    class Program
    {
        static void Main()
        {
            const string header = "Solutions to HackerRank exercises.";

            // write program header
            Console.WriteLine(Utility.GetProgramHeader(header, new DateTime(2017, 2, 20)));

            // start program timer
            var timer = new Stopwatch();
            timer.Start();

            // execute all modules
            RunWarmupQuestions();
            RunImplementationQuestions();
            RunStringQuestions();

            // stop timer
            timer.Stop();

            // write timer output
            Console.WriteLine("Program Execution: {0}ms", timer.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static void RunWarmupQuestions()
        {
            const string header = "Algorithms - Warm Up";
            RunQuestions(header, new List<IQuestion>()
            {
                new SimpleArraySum(),
                new CompareTheTriplets(),
                new VeryBigSum(),
                new DiagonalDifference(),
                new PlusMinus(),
                new Staircase(),
                new MinMaxSum(),
                new TimeConversion()
            });
        }

        private static void RunImplementationQuestions()
        {
            const string header = "Algorithms - Implementation";
            RunQuestions(header, new List<IQuestion>()
            {
                new GradingStudents(),
                new AppleAndOrange(),
                new Kangaroo(),
                new BetweenTwoSets(),
                new DivisibleSumPairs(),
                new BonAppetit(),
                new SockMerchant(),
                new DrawingBook(),
                new HurdleRace(),
                new DesignerPDFViewer(),
                new UtopianTree(),
                new AngryProfessor(),
                new BeautifulDaysAtMovies(),
                new ViralAdvertising(),
                new SaveThePrisoner(),
                new CircularArrayRotation(),
                new SequenceEquation(),
                new JumpingOnTheCloudsRevisited(),
                new FindDigits(),
                new AppendAndDelete(),
                new SherlockAndSquares(),
                new LibraryFine(),
                new CutTheSticks(),
                new RepeatedString(),
                new JumpingOnTheClouds(),
                new EqualizeTheArray(),
                new ACMICPCTeam(),
                new TaumAndBirthday(),
                new ModifiedKaprekarNumbers(),
                new BeautifulTriplets(),
                new MinimumDistances(),
                new ChocolateFeast(),
                new ServiceLane(),
                new LisasWorkbook(),
                new FlatlandSpaceStations(),
                new FairRations(),
                new CavityMap(),
                new ManasaAndStones(),
                new StrangeCounter()
            });
        }

        private static void RunStringQuestions()
        {
            const string header = "Algorithms - Strings";
            RunQuestions(header, new List<IQuestion>()
            {
                new SuperReducedString(),
                new CamelCase(),
                new CaeserCipher(),
                new MarsExploration(),
                new HackerRankInString(),
                new Pangram(),
                new WeightedUniformStrings(),
                new FunnyString(),
                new Gemstones(),
                new AlternatingCharacters(),
                new BeautifulBinaryString()
            });
        }
        private static void RunQuestions(string header, IReadOnlyList<IQuestion> questions)
        {
            Console.WriteLine(Utility.GetLessonHeader(header));
            for (var i = 0; i < questions.Count; i++)
            {
                questions[i].Run(i + 1);
                Console.WriteLine();
            }
        }
    }
}
