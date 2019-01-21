using Solid_Exercise.Interfaces;
using Solid_Exercise.Models.Factories;
using System;
using System.Collections.Generic;

namespace Solid_Exercise
{
	public class StartUp
	{
		static void Main(string[] args)
		{
			//test code
			//ILayout layout = new SimpleLayout();
			//IAppender appender = new ConsoleAppender(layout, ErrorLevel.Info);
			//ILogger logger = new Logger(new IAppender[] { appender });
			//IError error = new Error(DateTime.Now, ErrorLevel.Critical, "Critical error!");
			//logger.Log(error);

			ILogger logger = InitializeLogger();
			ErrorFactory errorFactory = new ErrorFactory();
			Engine engine = new Engine(logger, errorFactory);
			engine.Run();
		}

		static ILogger InitializeLogger()
		{
			ICollection<IAppender> appenders = new List<IAppender>();
			LayoutFactory layoutFactory = new LayoutFactory();
			AppenderFactory appenderFactory = new AppenderFactory(layoutFactory);
			int appenderCount = int.Parse(Console.ReadLine());

			for (int i = 0; i < appenderCount; i++)
			{
				string[] args = Console.ReadLine().Split();
				string appenderType = args[0];
				string layoutType = args[1];
				string errorLevel = "INFO";

				if (args.Length == 3)
				{
					errorLevel = args[2];
				}

				IAppender appender = appenderFactory.CreateAppender(appenderType, errorLevel, layoutType);
				appenders.Add(appender);
			}

			ILogger logger = new Logger(appenders);
			return logger;
		}
	}
}
