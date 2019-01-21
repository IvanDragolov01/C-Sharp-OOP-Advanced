namespace Solid_Exercise.Interfaces
{
	public interface ILogFile
	{
		string Path
		{
			get;
		}

		int Size
		{
			get;
		}

		void WriteToFile(string errrLog);
	}
}
