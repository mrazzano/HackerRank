using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.CrackingTheCodeInterview
{
    public class CrackingTheCodeInterviewModule : IModule
    {
        const string ModuleHeader = "Cracking the Code Interview: {0}";

        public void Execute()
        {
            // execute all modules
            RunDataStructureQuestions();
            RunAlgorithmQuestions();
            RunConceptQuestions();
        }

        private static void RunDataStructureQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Data Structures"), new List<IQuestion>()
            {
                new LeftRotation(),
                new MakingAnagrams(),
                new RansomNote(),
                new LinkedListDetectCycle(),
                new StacksBalancedBrackets(),
                new TaleOfTwoStacks(),
                new BinarySearchTree(),
                
            });
        }

        private static void RunAlgorithmQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Algorithms"), new List<IQuestion>()
            {
                new SortingBubbleSort(),
            });
        }

        private static void RunConceptQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Techniques/Concepts"), new List<IQuestion>()
            {
                new Primality(),
                new FibonacciNumbers()
            });
        }
    }
}
