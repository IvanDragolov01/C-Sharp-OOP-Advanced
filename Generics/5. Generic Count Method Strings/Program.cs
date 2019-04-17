using System;

namespace _5._Generic_Count_Method_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Box box = new Box;

			for (int i = 0; i < n; i++)
			{
				string text = Console.ReadLine();
				box.AddInList(text);
			}
		}
	}
}
