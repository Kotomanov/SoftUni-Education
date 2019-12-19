using System;
using System.Linq;

namespace RecursiveArraySum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine() // read the input , get the array of numbers
                .Split()
                .Select(int.Parse)
                .ToArray();

           int sum =  CalculateArraySum(input, 0);

            Console.WriteLine(sum);
        }

        // method with Recursion 

        static int CalculateArraySum(int[] array, int index)
        {
            if (index == array.Length ) // no further sum can be obtained
            {
                return 0;
            }

            Console.WriteLine($"Before {index}");
            // how do we get the sum????? // it calls the same till gets the bottom?
            int sum = array[index] + CalculateArraySum(array, index + 1);

            Console.WriteLine($"After {index}");

            return sum;
        }
    }
}
