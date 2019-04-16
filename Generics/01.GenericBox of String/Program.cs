using System;

namespace _01.GenericBox_of_String
{
	class Program
	{
		static void Main(string[] args)
		{
			int numbersOfStrings = int.Parse(Console.ReadLine());
			string result = string.Empty;

			for (int i = 0; i < numbersOfStrings; i++)
			{
				string text = Console.ReadLine();
				result += ($"{text.GetType()}: {text.ToString()}");
				result += Environment.NewLine;
			}

			Console.WriteLine(result);
		}
	}
}
