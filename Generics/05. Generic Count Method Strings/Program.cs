using System;

namespace _05.GenericCountMethodStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Box box = new Box();

			for (int i = 0; i < n; i++)
			{
				string text = Console.ReadLine();
				box.AddInList(text);
			}

			string finalString = Console.ReadLine();
			box.GetFinalElement(finalString);
			Console.WriteLine(box.isEqual());
		}
	}
}
