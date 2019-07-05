using System.Collections.Generic;

namespace _05.GenericCountMethodStrings
{
	public class Box
	{
		List<string> allElements = new List<string>();
		private string _finalElement;

		public void AddInList(string item)
		{
			allElements.Add(item);
		}

		public void GetFinalElement(string element)
		{
			_finalElement = element;
		}

		public int isEqual()
		{
			int greaterNumbers = 0;

			foreach (string element in allElements)
			{
				if (element.CompareTo(_finalElement) > 0)
				{
					greaterNumbers++;
				}
			}

			return greaterNumbers;
		}
	}
}
