using System.Globalization;

namespace Solid_Exercise
{
	public class SimpleLayout : ILayout
	{
		//error.DateTime error.Level - error.Message
		const string Format = "{0} - {1} - {2}";
		const string DateFormat = "M/d/yyyy h:mm:ss tt";

		public string FormatError(IError error)
		{
			string dateString = error.DateTime.ToString(DateFormat, CultureInfo.InvariantCulture);
			string errorMessage = string.Format(Format, dateString, error.Level.ToString(), error.Message);
			return errorMessage;
		}
	}
}
