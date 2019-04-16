using System;

namespace _02._Generic_Box_of_Integer
{
	class Program
	{
		static void Main(string[] args)
		{
			int numbersOfStrings = int.Parse(Console.ReadLine());
			string result = string.Empty;

			for (int i = 0; i < numbersOfStrings; i++)
			{
				int number = int.Parse(Console.ReadLine());
				result += ($"{number.GetType()}: {number}");
				result += Environment.NewLine;
			}

			Console.WriteLine(result);
		}
	}
}
