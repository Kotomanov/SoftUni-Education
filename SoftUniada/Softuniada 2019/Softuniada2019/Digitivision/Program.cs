using System;
using System.Collections.Generic;

namespace Digitivision
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstNumber = Console.ReadLine();
			string secondNumber = Console.ReadLine();
			string thirdNumber = Console.ReadLine();


			List<int> numbers = new List<int>(); // where to feed the numbers 

			int sum = int.Parse(firstNumber) + int.Parse(secondNumber) + int.Parse(thirdNumber); // OK 

			string firstComb = firstNumber + secondNumber + thirdNumber; // 1 2 3 
			string secondComb = firstNumber + thirdNumber + secondNumber;// 1 3 2 
			string thirdComb = thirdNumber + secondNumber + firstNumber;  // 3 2 1 
			string fourthComb = thirdNumber + firstNumber + secondNumber; // 3 1 2 
			string fifthComb = secondNumber + firstNumber + thirdNumber; // 2 1 3 
			string sixthComb = secondNumber + thirdNumber + firstNumber; // 2 3 1

			numbers.Add(int.Parse(firstComb));
			numbers.Add(int.Parse(secondComb));
			numbers.Add(int.Parse(thirdComb));
			numbers.Add(int.Parse(fourthComb));
			numbers.Add(int.Parse(fifthComb));
			numbers.Add(int.Parse(sixthComb));

			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] % sum == 0)
				{
					Console.WriteLine("Digitivision successful!"); return;
				}
			}

			Console.WriteLine("No digitivision possible.");

		}
	}
}
