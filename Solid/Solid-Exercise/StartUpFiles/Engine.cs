using System;
using Solid_Exercise.Interfaces;
using Solid_Exercise.Models.Factories;

namespace Solid_Exercise
{
	public class Engine
	{
		private ILogger _logger;
		private ErrorFactory _errorFactory;

		public Engine(ILogger logger, ErrorFactory errorFactory)
		{
			_logger = logger;
			_errorFactory = errorFactory;
		}

		public void Run()
		{
			string input;

			while ((input = Console.ReadLine()) != "END")
			{
				string[] errorArgs = input.Split('|');
				string level = errorArgs[0];
				string dateTime = errorArgs[1];
				string message = errorArgs[2];

				IError error = _errorFactory.CreateError(dateTime, level, message);
				_logger.Log(error);
			}

			Console.WriteLine("LoggerInfo");

			foreach (IAppender appender in _logger.Appenders)
			{
				Console.WriteLine(appender);
			}	
		}
	}
}
