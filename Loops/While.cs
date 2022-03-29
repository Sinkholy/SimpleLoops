using System;

namespace SimpleLoops.Loops
{
	internal static class While
	{
		internal static void Execute(Func<bool> condition, Action operation)
		{
			while (condition())
			{
				operation();
			}
		}
	}
}
