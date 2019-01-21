using Solid_Exercise.Interfaces;
using System.Collections.Generic;

namespace Solid_Exercise
{
	public class Logger : ILogger
	{
		IEnumerable<IAppender> _appenders;

		public Logger(IEnumerable<IAppender> appenders)
		{
			_appenders = appenders;
		}

		public IReadOnlyCollection<IAppender> Appenders => (IReadOnlyCollection<IAppender>)_appenders;

		public void Log(IError error)
		{
			foreach (IAppender appender in _appenders)
			{
				if (appender.Level <= error.Level)
				{
					appender.Append(error);
				}
			}
		}
	}
}
