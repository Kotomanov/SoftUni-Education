using System;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersLength = int.Parse(Console.ReadLine());

            int[] array = new int[numbersLength];

            GenerateVector(array, 0); // why zero and not the index????

        }

        static void GenerateVector(int [] vector, int index)
        {
            if (index == vector.Length)
            {
                Print(vector); 
            }

            else
            {
                for (int i = 0; i <= 1; i++) // as we have 0 and 1 only 
                {
                    vector[index] = i;

                    GenerateVector(vector, index+ 1 );
                }
            }
        }

        static void Print(int [] vector)
        {
            Console.WriteLine(string.Join("", vector));
        }
    }
}
