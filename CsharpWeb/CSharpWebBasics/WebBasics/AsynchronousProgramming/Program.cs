using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        static int counter;

        static async Task Main(string[] args)
        {
            // done the right way :

            try
            {
                HttpClient client = new HttpClient();
                var httpResponse = await client.GetAsync("https://softuni1.bg");
                var result = await httpResponse.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
            



            //can  be done wuth annonimous method
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


            //Console.WriteLine(amount);

            // using separate therads with for and ConcurrentQueue

            var numbers = new ConcurrentQueue<int>(Enumerable.Range(0, 10000).ToList());

            for (int i = 0; i < 4; i++)
            {
                new Thread(() =>
                {
                    while (numbers.Count > 0)
                    {
                        numbers.TryDequeue(out _);
                    }
                }).Start();
            }




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
