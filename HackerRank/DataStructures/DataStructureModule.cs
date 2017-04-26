using System.Collections.Generic;
using HackerRank.Library;
using HackerRank.DataStructures.Arrays;

namespace HackerRank.DataStructures
{
    public class DataStructureModule : IModule
    {
        const string ModuleHeader = "Data Structures: {0}";

        public void Execute()
        {
            // execute all modules
            RunArrayQuestions();
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
    }
}
