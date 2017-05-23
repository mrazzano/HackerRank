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
                new SortingBubbleSort()
            });
        }
    }
}
