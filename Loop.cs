using System;

using SimpleLoops.ConditionSelectors;

namespace SimpleLoops
{
	public class Loop
	{
		public static IConditionSelector Repeat(Action operation)
		{
			return new ConditionSelector(operation);
		}
		public static IConditionSelector RepeatWithIndexProviding(Action<int> operation)
		{
			return new ConditionSelectorWithIndexProviding(operation);
		}
	}
}