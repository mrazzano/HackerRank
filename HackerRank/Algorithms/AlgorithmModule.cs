using System.Collections.Generic;
using HackerRank.Library;
using HackerRank.Algorithms.Search;
using HackerRank.Algorithms.WarmUp;
using HackerRank.Algorithms.Sorting;
using HackerRank.Algorithms.Strings;
using HackerRank.Algorithms.Greedy;
using HackerRank.Algorithms.Recursion;
using HackerRank.Algorithms.GameTheory;
using HackerRank.Algorithms.Implementation;
using HackerRank.Algorithms.BitManipulation;

namespace HackerRank.Algorithms
{
    public class AlgorithmModule : IModule
    {
        const string ModuleHeader = "Algorithms: {0}";

        public void Execute()
        {
            // execute all modules
            RunWarmupQuestions();
            RunImplementationQuestions();
            RunStringQuestions();
            RunSortingQuestions();
            RunSearchQuestions();
            RunGreedyQuestions();
            RunBitManipulationQuestions();
            RunRecursionQuestions();
            RunGameTheoryQuestions();
        }

        private static void RunWarmupQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Warm Up"), new List<IQuestion>()
            {
                new SimpleArraySum(),
                new CompareTheTriplets(),
                new VeryBigSum(),
                new DiagonalDifference(),
                new PlusMinus(),
                new Staircase(),
                new MinMaxSum(),
                new BirthdayCakeCandles(),
                new TimeConversion()
            });
        }

        private static void RunImplementationQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Implementation"), new List<IQuestion>()
            {
                new GradingStudents(),
                new AppleAndOrange(),
                new Kangaroo(),
                new BetweenTwoSets(),
                new BirthdayChocolate(),
                new DivisibleSumPairs(),
                new MigratoryBirds(),
                new BonAppetit(),
                new SockMerchant(),
                new DrawingBook(),
                new CountingValleys(),
                new ElectronicsShop(),
                new CatsAndMouse(),
                new PickingNumbers(),
                new ClimbingTheLeaderboard(),
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
                new StrangeCounter(),
            });
        }

        private static void RunStringQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Strings"), new List<IQuestion>()
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
            Utility.RunQuestions(string.Format(ModuleHeader, "Sorting"), new List<IQuestion>()
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
                new FindTheMedian(),
                new BigSorting()
            });
        }

        private static void RunSearchQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Search"), new List<IQuestion>()
            {
                new HackerlandRadioTransmitters(),
                new IceCreamParlor(),
                new MissingNumbers(),
                new SherlockAndArray()
            });
        }

        private static void RunGreedyQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Greedy"), new List<IQuestion>()
            {
                new MinimumAbsoluteDifference(),
                new MarksCakewalk(),
                new LuckBalance(),
                new MaxPerimeterTriangle(),
                new BeautifulPairs(),
                new SherlockAndTheBeast(),
                new PriyankaAndToys(),
                new LargestPermutation(),
                new MarkAndToys(),
                new JimAndTheOrders(),
                new PermutingTwoArrays()
            });
        }

        private static void RunBitManipulationQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Bit Manipulation"), new List<IQuestion>()
            {
                new LonelyInteger(),
                new MaximizingXOR(),
                new FlippingBits(),
                new SumVsXOR()
            });
        }

        private static void RunRecursionQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Recursion"), new List<IQuestion>()
            {
                new PowerSum()
            });
        }

        private static void RunGameTheoryQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Game Theory"), new List<IQuestion>()
            {
                new GameOfStones(),
                new TowerBreakers(),
                new ChessboardGame(),
                new IntroductionToNimGame(),
                new MisereNim(),
                new PokerNim(),
                new NimbleGame()
            });
        }
    }
}
