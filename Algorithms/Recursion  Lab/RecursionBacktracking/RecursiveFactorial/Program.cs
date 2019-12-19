using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); // get the number 

            long result = CalculateFactorial(number);

            Console.WriteLine(result);

        }

        static long CalculateFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            Console.WriteLine($"Before {number}");

            long result = number * CalculateFactorial(number - 1);

            Console.WriteLine($"After {number}");

            return result;

        }


    }
}
