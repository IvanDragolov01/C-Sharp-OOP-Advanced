using System.Collections.Generic;
using System.Linq;

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
			int greaterNumbers = 0;

			foreach (string element in allElements)
			{
				if (element.Equals(_finalElement) && element.Count() == _finalElement.Count())
				{
				}
				else
				{
					greaterNumbers++;
				}
			}

			return greaterNumbers;
		}
	}
}
