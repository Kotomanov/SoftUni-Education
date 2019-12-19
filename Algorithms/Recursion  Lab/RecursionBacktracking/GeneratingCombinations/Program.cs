using System;
using System.Linq;

namespace GeneratingCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int outputLength = int.Parse(Console.ReadLine()); // how long is the output 

            int[] output = new int[outputLength]; // store the output array 

            GenerateCombination(input, output, 0, 0);

        }

        private static void GenerateCombination(int[] set, int[] vector, int index, int border)
        {
            if (index == vector.Length) // when the k length is full, we need to print the combination 
            {
                Console.WriteLine(string.Join(" ", vector));
            }

            else
            {
                for (int i = border; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    // vector = result 
                    // index where we are now 
                    // set is input array 

                    GenerateCombination(set, vector, index + 1, i + 1);
                }
            }

        }



    }
}
