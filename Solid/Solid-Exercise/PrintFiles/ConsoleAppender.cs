using Solid_Exercise.Interfaces;
using System;

namespace Solid_Exercise.Models
{
	public class ConsoleAppender : IAppender
	{
		public ConsoleAppender(ILayout layout, ErrorLevel level)
		{
			Layout = layout;
			Level = level;
		}

		public ILayout Layout
		{
			get;
		}

		public ErrorLevel Level
		{
			get;
		}

		public int MessagesAppended
		{
			get;
			private set;
		}

		public void Append(IError error)
		{
			string formatedError = Layout.FormatError(error);
			Console.WriteLine(formatedError);
			MessagesAppended++;
		}

		public override string ToString()
		{
			string appenderType = GetType().Name;
			string layoutType = Layout.GetType().Name;
			string level = Level.ToString();
			string result = $"Appender type: {appenderType}, Layout type: {layoutType}, Report level: {level}, Messages appended: {MessagesAppended}";

			return result;
		}
	}
}
