using System;

using static SimpleLoops.Operations;

namespace SimpleLoops.Loops
{
	internal static class While
	{
		internal static void Execute(Func<bool> condition, WithOutIndexer operation)
		{
			bool conditionMet = condition();
			while (conditionMet)
			{
				operation();
			}
		}
		internal static void Execute(Func<bool> condition, WithIndexer operation)
		{
			int iteration = 0;
			bool conditionMet = condition();
			while (conditionMet)
			{
				operation(iteration);
				iteration++;
			}
		}
	}
}