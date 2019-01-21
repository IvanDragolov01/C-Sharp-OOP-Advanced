using System;
using Solid_Exercise.Interfaces;
using Solid_Exercise.Logs;

namespace Solid_Exercise.Models.Factories
{
	public class AppenderFactory
	{
		const string DefaultFileName = "logFile{0}.txt";
		private LayoutFactory _layoutFactory;
		private int _fileNumber;

		public AppenderFactory(LayoutFactory layoutFactory)
		{
			_layoutFactory = layoutFactory;
			_fileNumber = 0;
		}

		public IAppender CreateAppender(string appenderType, string levelString, string layoutType)
		{
			ILayout layout = _layoutFactory.CreateLayout(layoutType);
			ErrorLevel errorLevel = ParseErrorLevel(levelString);
			IAppender appender = null;

			switch (appenderType)
			{
				case "ConsoleAppender":
					appender = new ConsoleAppender(layout, errorLevel);
					break;
				case "FileAppender":
					ILogFile logFile = new LogFile(string.Format(DefaultFileName,_fileNumber));
					appender = new FileAppender(layout, errorLevel, logFile);
					break;
				default:
					throw new ArgumentException("Invalid Appender Type");
			}

			return appender;
		}

		private ErrorLevel ParseErrorLevel(string levelString)
		{
			try
			{
				object levelObjs = Enum.Parse(typeof(ErrorLevel), levelString);
				ErrorLevel levelObj = (ErrorLevel)levelObjs;
				return levelObj;
			}
			catch (ArgumentException e)
			{
				throw new ArgumentException("Invalid ErrorLevel Type!", e);
			}
		}
	}
}
