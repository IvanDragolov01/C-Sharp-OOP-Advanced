﻿using System;

namespace _02.GenericBoxofInteger
{
	class Program
	{
		static void Main(string[] args)
		{
			int number;
			number = int.Parse(Console.ReadLine());

			for (int i = 0; i < number; i++)
			{
				int num = int.Parse(Console.ReadLine());
				Box<int> box = new Box<int>(num);
				Console.WriteLine(box.ToString());
			}
			
		}
	}
}