using System;

namespace _01.GenericBox_of_String
{
	class Program
	{
		static void Main(string[] args)
		{
			Box<int> box1 = new Box<int>(int.MinValue);
			Box<string> box2 = new Box<string>("life in a box");

			Console.WriteLine(box1);
			Console.WriteLine(box2);
		}
	}
}