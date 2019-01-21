namespace Solid_Exercise
{
	using Solid_Exercise.Interfaces;
	using System.Collections.Generic;

	public interface ILogger
	{
		IReadOnlyCollection<IAppender> Appenders
		{
			get;	
		}

		void Log(IError error);
	}
}
