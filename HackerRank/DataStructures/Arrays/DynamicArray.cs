using System;
using HackerRank.Library;

namespace HackerRank.DataStructures.Arrays
{
    public class DynamicArray : IQuestion
    {
        private const string question = "Dynamic Array";

        public void Run(int order)
        {
            Utility.PrintQuestionHeader(order, question);

            var args = new[] { "2 5", "1 0 5", "1 1 7", "1 0 3", "2 1 0", "2 1 1" };
            solution(args);
        }

        private static void solution(string[] args)
        {
            var tokens = args[0].Split(' ');
            var n = Convert.ToInt32(tokens[0]);
            var q = Convert.ToInt32(tokens[1]);

            var last = 0;
            var result = new int[n][];
            for (var i = 0; i < n; i++)
            {
                result[i] = new int[0];
            }

            for (var i = 1; i <= q; i++)
            {
                tokens = args[i].Split(' ');
                var type = Convert.ToInt32(tokens[0]);
                var x = Convert.ToInt32(tokens[1]);
                var y = Convert.ToInt32(tokens[2]);

                if (type == 1)
                {
                    var index = ((x ^ last) % n);
                    result[index] = addToArray(result[index], y);
                }
                else
                {
                    var index = ((x ^ last) % n);
                    last = result[index][(y % result[index].Length)];
                    
                    Console.WriteLine(last);
                }
            }
        }

        private static int[] addToArray(int[] array, int value)
        {
            var output = new int[array.Length + 1];
            for (var i = 0; i < array.Length; i++)
            {
                output[i] = array[i];
            }
            output[array.Length] = value;
            return output;
        }
    }
}
