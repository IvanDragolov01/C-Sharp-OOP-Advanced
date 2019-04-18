using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.CustomList
{
	class Box
	{
		private List<string> elements = new List<string>();

		public void Add(string element)
		{
			elements.Add(element);
		}

		public void Remove(int index)
		{
			elements.Remove(elements[index]);
		}

		public bool IsContains(string word)
		{
			if (elements.Contains(word))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public void PrintAllElements()
		{
			foreach (string element in elements)
			{
				Console.WriteLine(element);
			}
		}

		public void SwapElements(int x, int y)
		{
			string element = elements[x];
			elements[x] = elements[y];
			elements[y] = element;
		}

		public void Greater(string greaterWord)
		{
			int counter = 0;

			foreach (string element in elements)
			{
				if (element.CompareTo(greaterWord) > 0)
				{
					counter++;
				}
			}

			Console.WriteLine(counter);
		}

		public void PrintMaxElement()
		{
			Console.WriteLine(elements.Max());
		}

		public void PrintMinElement()
		{
			Console.WriteLine(elements.Min());
		}
	}
}
