using System.Collections.Generic;
using HackerRank.Library;
using HackerRank.DataStructures.Arrays;
using HackerRank.DataStructures.LinkedLists;

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
                new DeleteNode() ,
                new ReverseLinkedList(),
                new CompareLinkedLists(),
                new MergeLinkedLists(),
                new NthFromLastNode(),
                new DeleteDuplicates(),
                new DetectCycle()
            });
        }
    }
}
