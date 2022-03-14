using System;

namespace SimpleLoops.Loops
{
	internal static class ForWithIndexProviding
	{
		internal static void Execute(int iterations, Action<int> operation)
		{
			for (int currentIteration = 0; currentIteration < iterations; currentIteration++)
			{
				operation(currentIteration);
			}
		}
	}
}
