using System;

namespace _10.Tuple
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(" ");
			string name = string.Concat(input[0], input[1]);
			string address = input[2];
			Tuple<string, string> nameAndAddress = new Tuple<string, string>(name, address);
			Console.WriteLine(nameAndAddress.ToString());

			input = Console.ReadLine().Split(" ");
			name = input[0];
			int litersOfBeer = int.Parse(input[1]);
			Tuple<string, int> nameAndBeerLiters = new Tuple<string, int>(name, litersOfBeer);
			Console.WriteLine(nameAndBeerLiters.ToString());

			input = Console.ReadLine().Split(" ");
			int integerNumber = int.Parse(input[0]);
			double doubleNumber = double.Parse(input[1]);
			Tuple<int, double> integerAndDouble = new Tuple<int, double>(integerNumber, doubleNumber);
			Console.WriteLine(integerAndDouble.ToString());

		}
	}
}
