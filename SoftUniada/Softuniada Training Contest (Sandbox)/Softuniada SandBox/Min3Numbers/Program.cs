using System;
using System.Collections.Generic;

namespace Min3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < counter; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 3)
                {
                    return;
                }

                Console.WriteLine(numbers[i]);

            }
        }
    }
}
