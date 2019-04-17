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

		public string GetFinalElement(string element)
		{
			_finalElement = element;
			return _finalElement;
		}

		public int isEqual()
		{
			int equalsNumbers = 0;

			foreach (string element in allElements)
			{
				if (element != _finalElement)
				{
					equalsNumbers++;
				}
			}

			return equalsNumbers;
		}
	}
}
