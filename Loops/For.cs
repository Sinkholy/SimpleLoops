using System;

using static SimpleLoops.Operations;

namespace SimpleLoops.Loops
{
	internal static class For
	{
		internal static void Execute(int iterations, WithOutIndexer operation)
		{
			for (int currentIteration = 0; currentIteration < iterations; currentIteration++)
			{
				operation();
			}
		}
		internal static void Execute(int iterations, WithIndexer operation)
		{
			for (int currentIteration = 0; currentIteration < iterations; currentIteration++)
			{
				operation(currentIteration);
			}
		}
	}
}