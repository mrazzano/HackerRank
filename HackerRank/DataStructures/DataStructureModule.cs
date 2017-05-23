using System.Collections.Generic;
using HackerRank.Library;
using HackerRank.DataStructures.Arrays;
using HackerRank.DataStructures.LinkedLists;
using HackerRank.DataStructures.Stacks;
using HackerRank.DataStructures.Trees;

namespace HackerRank.DataStructures
{
    public class DataStructureModule : IModule
    {
        const string ModuleHeader = "Data Structures: {0}";

        public void Execute()
        {
            // execute all modules
            RunArrayQuestions();
            RunLinkedListQuestions();
            RunTreeQuestions();
            RunStackQuestions();
        }
         
        private static void  RunArrayQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Arrays"), new List<IQuestion>()
            {
                new ArraysDS(),
                new LeftRotation(),
                new SparseArrays(),
                new TwoDimensionalArray(),
                new DynamicArray()
            });
        }

        private static void RunLinkedListQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Linked Lists"), new List<IQuestion>()
            {
                new PrintElements(),
                new InsertNodeAtTail(),
                new InsertNodeAtHead(),
                new InsertNodeAtPosition(),
                new DeleteNode(),
                new ReverseLinkedList(),
                new CompareLinkedLists(),
                new MergeLinkedLists(),
                new NthFromLastNode(),
                new DeleteDuplicates(),
                new DetectCycle(),
                new MergePointLinkedLists()
            });
        }

        private static void RunTreeQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Trees"), new List<IQuestion>()
            {
                new PreorderTraversal(),
                new PostorderTraversal(),
                new InorderTraversal(),
                new TreeHeight(),
                new TopView(),
                new LevelorderTraversal(),
                new InsertTreeNode(),
                new LowestCommonAncestor()
            });
        }

        private static void RunStackQuestions()
        {
            Utility.RunQuestions(string.Format(ModuleHeader, "Stacks"), new List<IQuestion>()
            {
                new StackMaximumElement(),
                new BalancedBrackets()
            });
        }
    }
}
