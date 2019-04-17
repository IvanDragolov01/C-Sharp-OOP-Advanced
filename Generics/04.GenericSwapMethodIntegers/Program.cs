using System;
using System.Collections.Generic;

namespace _04.GenericSwapMethodIntegers
{
	public class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<int> numbersLength = new List<int>();

			for (int i = 0; i < n; i++)
			{
				int line = int.Parse(Console.ReadLine());
				numbersLength.Add(line);
			}

			//int[] masiv = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
			string[] numbers = Console.ReadLine()
				.Split(" ");

			int swapNumbers = int.Parse(numbers[0]);
			int swapNumbers2 = int.Parse(numbers[1]);
			int forChange = numbersLength[swapNumbers];
			numbersLength[swapNumbers] = numbersLength[swapNumbers2];
			numbersLength[swapNumbers2] = forChange;

			foreach (int num in numbersLength)
			{
				Console.WriteLine($"{num.GetType()}: {num}");
			}
		}
	}
}
