using System;

namespace Solid_Exercise.Models
{
	public class Error : IError
	{
		public Error(DateTime dateTime, ErrorLevel level, string message)
		{
			DateTime = dateTime;
			Message = message;
			Level = level;
		}

		public DateTime DateTime
		{
			get;
		}

		public string Message
		{
			get;
		}

		public ErrorLevel Level
		{
			get;
		}
	}
}
