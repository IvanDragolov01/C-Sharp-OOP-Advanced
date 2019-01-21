using Solid_Exercise.Interfaces;
using System;
using System.IO;

namespace Solid_Exercise.Logs
{
	public class LogFile : ILogFile
	{
		const string DefaultPath = "./data/";

		public LogFile(string fileName)
		{
			Path = DefaultPath + fileName;
			InitializeFile();
			Size = 0;
		}

		public string Path
		{
			get;
		}

		private void InitializeFile()
		{
			Directory.CreateDirectory(DefaultPath);
			File.AppendAllText(Path, "");
		}

		public int Size
		{
			get;
			private set;
		}

		public void WriteToFile(string errorLog)
		{
			File.AppendAllText(Path, errorLog + Environment.NewLine);
			int addedSize = 0;

			for (int i = 0; i < errorLog.Length; i++)
			{
				addedSize += errorLog[i];
				Size += addedSize;
			}
		}
	}
}
