using System;
using System.Diagnostics;

namespace AsynchronousProgramming
{
    class Program
    {
        static int counter;

        static void Main(string[] args)
        {

            var time = Stopwatch.StartNew();
            Console.WriteLine(CountOfPrimeNumbersInRange(1, 1_000_000));
            Console.WriteLine(time.Elapsed);
        }

        private static int CountOfPrimeNumbersInRange(int from, int to)
        {

            for (int i = from; i <= to; i++)
            {
                bool IsPrime = true;
                for (int div = 2; div <= Math.Sqrt(i); div++)
                {
                    if (i % div == 0)
                    {
                        IsPrime = false;
                    }
                }

                if (IsPrime)
                {
                    counter++;
                }
            }


            return counter;
        }
    }
}
