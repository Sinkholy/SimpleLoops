using System;

namespace SimpleLoops.Loops
{
	internal static class For
	{
		internal static void Execute(int iterations, Action operation)
		{
			for (int currentIteration = 0; currentIteration < iterations; currentIteration++)
			{
				operation();
			}
		}
	}
}