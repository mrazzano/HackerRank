using System;
using System.Diagnostics;
using HackerRank.Library;
using System.Collections.Generic;
using HackerRank.Algorithms.Greedy;
using HackerRank.Algorithms.WarmUp;
using HackerRank.Algorithms.Strings;
using HackerRank.Algorithms.Sorting;
using HackerRank.Algorithms.Implementation;
using HackerRank.Algorithms.Search;

namespace HackerRank
{
    class Program
    {
        static void Main()
        {
            const string header = "Solutions to HackerRank exercises.";

            // write program header
            Console.WriteLine(Utility.GetProgramHeader(header));

            // start program timer
            var timer = new Stopwatch();
            timer.Start();

            // execute all modules
            RunWarmupQuestions();
            RunImplementationQuestions();
            RunStringQuestions();
            RunSortingQuestions();
            RunSearchQuestions();
            RunGreedyQuestions();

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
                new TwoCharacters(),
                new CaeserCipher(),
                new MarsExploration(),
                new HackerRankInString(),
                new Pangram(),
                new WeightedUniformStrings(),
                new FunnyString(),
                new Gemstones(),
                new AlternatingCharacters(),
                new BeautifulBinaryString(),
                new LoveLetterMystery(),
                new PalindromeIndex(),
                new Anagram(),
                new MakingAnagrams(),
                new GameOfThrones(),
                new TwoStrings(),
                new StringConstruction()
,            });
        }

        private static void RunSortingQuestions()
        {
            const string header = "Algorithms - Sorting";
            RunQuestions(header, new List<IQuestion>()
            {
                new InsertionSortPart1(),
                new InsertionSortPart2(),
                new RunningTimeOfInsertionSort(),
                new QuicksortPartition(),
                new QuicksortSorting(),
                new QuicksortInPlace(),
                new RunningTimeOfQuicksort(),
                new CountingSort1(),
                new CountingSort2(),
                new CountingSort3(),
                new ClosestNumbers(),
                new FindTheMedian()
            });
        }

        private static void RunSearchQuestions()
        {
            const string header = "Algorithms - Search";
            RunQuestions(header, new List<IQuestion>()
            {
                new HackerlandRadioTransmitters(),
                new IceCreamParlor(),
                new MissingNumbers(),
                new SherlockAndArray()
            });
        }

        private static void RunGreedyQuestions()
        {
            const string header = "Algorithms - Greedy";
            RunQuestions(header, new List<IQuestion>()
            {
                new MinimumAbsoluteDifference()
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
