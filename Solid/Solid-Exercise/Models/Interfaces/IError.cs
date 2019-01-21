using System;

namespace Solid_Exercise
{
	public interface IError : ILevelable
	{
		DateTime DateTime 
		{
			get;
		}

		string Message
		{
			get;
		}
	}
}