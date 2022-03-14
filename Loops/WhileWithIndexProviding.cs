using System;

namespace SimpleLoops.Loops
{
	internal static class WhileWithIndexProviding
	{
		internal static void Execute(Func<bool> condition, Action<int> operation)
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
