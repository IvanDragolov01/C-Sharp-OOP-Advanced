using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.CustomListIterator
{
	public class Box
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

		public void IsContains(string word)
		{
			if (elements.Contains(word))
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
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

		public void SortElements()
		{
			elements.Sort();
		}

		public void PrintMinElement()
		{
			Console.WriteLine(elements.Min());
		}

		public IEnumerator<string> GetEnumerator()
		{
			for (int i = 0; i < elements.Count; i++)
			{
				yield return elements[i];
			}
		}

		//IEnumerator IEnumerable.GetEnumerator()
		//{
		//	return GetEnumerator();
		//}

		//private void ValidateIndex(int index)
		//{
		//	if (index < 0 || index > elements.Count - 1)
		//	{
		//		throw new IndexOutOfRangeException();
		//	}
		//}
	}
}
