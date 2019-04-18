using System;

namespace _07.CustomList
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] command = Console.ReadLine().Split(" ");
			Box box = new Box();

			while (command[0] != "END")
			{
				switch (command[0])
				{
					case "Add":
						string word = command[1];
						box.Add(word);
						break;
					case "Remove":
						int indexToRemove = int.Parse(command[1]);
						box.Remove(indexToRemove);
						break;
					case "Contains":
						string wordIsContains = command[1];
						box.IsContains(wordIsContains);
						break;
					case "Swap":
						string[] tokens = command[1].Split(" ");
						int indexOne = int.Parse(tokens[0]);
						int indexTwo = int.Parse(tokens[1]);
						box.SwapElements(indexOne, indexTwo);
						break;
					case "Greater":
						string greaterWord = command[1];
						box.Greater(greaterWord);
						break;
					case "Max":
						box.PrintMaxElement();
						break;
					case "Min":
						box.PrintMinElement();
						break;
					case "Print":
						box.PrintAllElements();
						break;
				}

				command[0] = Console.ReadLine();
			}
		}
	}
}
