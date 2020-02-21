using System;
using System.Collections.Generic;
using System.Linq;

namespace Nexus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondLine = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> firstTemp = firstLine;
            List<int> secondTemp = secondLine;

            List<int> newfirst = new List<int>();
            List<int> newSecond = new List<int>();


            string command = string.Empty;
            List<string> input = new List<string>();
            int firstIndex = 0;
            int secondIndex = 0;
            int thirdIndex = 0;
            int fourthIndex = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;

            int totalSum = 0;

            while ((command = Console.ReadLine()) != "nexus")
            {
                input = command.Split("|").ToList();
                firstIndex = int.Parse(input[0].Split(":")[0]);
                secondIndex = int.Parse(input[0].Split(":")[1]);
                thirdIndex = int.Parse(input[1].Split(":")[0]);
                fourthIndex = int.Parse(input[1].Split(":")[1]);

                if (thirdIndex > firstIndex && secondIndex > fourthIndex || thirdIndex < firstIndex && secondIndex < fourthIndex)
                {
                    for (int i = 0; i < firstTemp.Count; i++)
                    {
                        if (thirdIndex > firstIndex && secondIndex > fourthIndex)
                        {
                            if (i >= 0 && i < firstIndex)
                            {
                                newfirst.Add(firstTemp[i]);
                            }

                            if (i > thirdIndex && i < firstTemp.Count)
                            {
                                newfirst.Add(firstTemp[i]);
                            }
                        }

                        else if (thirdIndex < firstIndex && secondIndex < fourthIndex)
                        {

                            if (i >= 0 && i < thirdIndex)
                            {
                                newfirst.Add(firstTemp[i]);
                            }

                            if (i > firstIndex && i < firstTemp.Count)
                            {
                                newfirst.Add(firstTemp[i]);
                            }
                        }

                        sum1 = firstTemp[firstIndex];
                        sum3 = firstTemp[thirdIndex];
                    }

                    for (int j = 0; j < secondTemp.Count; j++)
                    {
                        if (thirdIndex > firstIndex && secondIndex > fourthIndex)
                        {
                            if (j >= 0 && j < fourthIndex)
                            {
                                newSecond.Add(secondTemp[j]);
                            }

                            if (j > secondIndex && j < secondTemp.Count)
                            {
                                newSecond.Add(secondTemp[j]);
                            }

                        }


                        else if (thirdIndex < firstIndex && secondIndex < fourthIndex)
                        {

                            if (j >= 0 && j < thirdIndex)
                            {
                                newSecond.Add(secondTemp[j]);
                            }

                            if (j > firstIndex && j < secondTemp.Count)
                            {
                                newSecond.Add(secondTemp[j]);
                            }

                        }

                        sum2 = secondTemp[secondIndex];
                        sum4 = secondTemp[fourthIndex];
                    }


                    if (newfirst.Count > 0 && newSecond.Count > 0)
                    {
                        totalSum = sum1 + sum2 + sum3 + sum4;

                        for (int l = 0; l < newfirst.Count; l++)
                        {
                            newfirst[l] += totalSum;
                        }

                        for (int p = 0; p < newSecond.Count; p++)
                        {
                            newSecond[p] += totalSum;
                        }
                    }

                    firstTemp = newfirst;
                    secondTemp = newSecond;
                    newfirst = new List<int>();
                    newSecond = new List<int>();
                }

            }

            Console.WriteLine(String.Join(", ", firstTemp));
            Console.WriteLine(String.Join(", ", secondTemp));

        }
    }
}
