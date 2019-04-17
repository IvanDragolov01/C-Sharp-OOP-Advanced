using System;
using System.Collections.Generic;

namespace _03.GenericSwapMethodString
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<string> text = new List<string>();

			for (int i = 0; i < n; i++)
			{
				string line = Console.ReadLine();
				text.Add(line);
			}

			//int[] masiv = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
			string[] numbers = Console.ReadLine()
				.Split(" ");

			int swapNumbers = int.Parse(numbers[0]);
			int swapNumbers2 = int.Parse(numbers[1]);
			string forChange = text[swapNumbers];
			text[swapNumbers] = text[swapNumbers2];
			text[swapNumbers2] = forChange;

			foreach (string words in text)
			{
				Console.WriteLine($"{words.GetType()}: {words}");
			}
		}
	}
}
