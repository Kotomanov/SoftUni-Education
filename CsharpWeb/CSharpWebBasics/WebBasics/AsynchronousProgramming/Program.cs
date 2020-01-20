using System;
using System.Diagnostics;
using System.Threading;

namespace AsynchronousProgramming
{
    class Program
    {
        static int counter;

        static void Main(string[] args)
        {//can  be done wuth annonimous method
            new Thread(() =>
            {
                while (true)
                {
                    // Console.WriteLine(1);
                }
            }).Start();


            new Thread(() =>
            {
                while (true)
                {
                    // Console.WriteLine(5);
                }
            }).Start();

            // parallel  feeding an account 

            decimal amount = 0;

            object lockObject = new object();

            var thread1 = new Thread(
                () =>
                {
                    for (int i = 0; i < 100_000; i++)
                    {
                        lock (lockObject)
                        {
                            amount++;
                        }

                    }
                }
                );
            thread1.Start();

            var thread2 = new Thread(
                () =>
                {
                    for (int i = 0; i < 100_000; i++)
                    {
                        lock (lockObject)
                        {
                            amount++;
                        }

                    }
                }
                );
            thread2.Start();

            var thread3 = new Thread(
                () =>
                {
                    for (int i = 0; i < 100_000; i++)
                    {
                        lock (lockObject)
                        {
                            amount++;
                        }

                    }
                }
                );
            thread3.Start();
            thread1.Join();
            thread2.Join();
            thread3.Join();


            Console.WriteLine(amount);

            // can be instantiazed : 
            Thread thread = new Thread(MyThreadMainMethod);
            thread.Start();

            while (true)
            {
                string line = Console.ReadLine();
                //Console.WriteLine(line.ToUpper());
            }

        }

        private static void MyThreadMainMethod()
        {
            var time = Stopwatch.StartNew();
            //Console.WriteLine(CountOfPrimeNumbersInRange(1, 1_000_000));
            //Console.WriteLine(time.Elapsed);
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
