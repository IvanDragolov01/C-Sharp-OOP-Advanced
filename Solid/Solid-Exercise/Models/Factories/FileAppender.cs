using Solid_Exercise.Interfaces;

namespace Solid_Exercise.Models.Factories
{
	internal class FileAppender : IAppender
	{
		private ILogFile _logFile;

		public FileAppender(ILayout layout, ErrorLevel errorLevel, ILogFile logFile)
		{
			Layout = layout;
			Level = errorLevel;
			_logFile = logFile;
			MessagesAppended = 0;
		}

		public ILayout Layout { get; }

		public ErrorLevel Level { get; }

		public int MessagesAppended { get; private set; }

		public void Append(IError error)
		{
			string formattedError = Layout.FormatError(error);
			_logFile.WriteToFile(formattedError);
			MessagesAppended++;
		}

		public override string ToString()
		{
			string appenderType = GetType().Name;
			string layoutType = Layout.GetType().Name;
			string level = Level.ToString();
			string result = $"Appender type: {appenderType}, Layout type: {layoutType}, Report level: {level}, Messages appended: {MessagesAppended} File size: {_logFile.Size}";

			return result;
		}
	}
}