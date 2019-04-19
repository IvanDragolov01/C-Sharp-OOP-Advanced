using System;

namespace _11.ThreeTuple
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(" ");
			string name = string.Concat(input[0], input[1]);
			string address = input[2];
			string town = input[3];
			Tuple<string, string, string> nameAndAddressAndTown = new Tuple<string, string, string>(name, address, town);
			Console.WriteLine(nameAndAddressAndTown.ToString());

			input = Console.ReadLine().Split(" ");
			name = input[0];
			int litersOfBeer = int.Parse(input[1]);
			string word = input[2];
			bool IsDrunk = false;

			if (word == "drunk")
			{
				IsDrunk = true;
			}
			else
			{
				IsDrunk = false;
			}

			Tuple<string, int, bool> nameAndBeerLiters = new Tuple<string, int, bool>(name, litersOfBeer, IsDrunk);
			Console.WriteLine(nameAndBeerLiters.ToString());

			input = Console.ReadLine().Split(" ");
			string nameOfUser = input[0];
			double accountBalance = double.Parse(input[1]);
			string bankName = input[2];
			Tuple<string, double, string> integerAndDouble = new Tuple<string, double, string>(nameOfUser, accountBalance, bankName);
			Console.WriteLine(integerAndDouble.ToString());
		}
	}
}
