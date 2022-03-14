using System;

namespace SimpleLoops.ConditionSelectors
{
	public class ConditionSelectorWithIndexProviding : IConditionSelector
	{
		readonly Action<int> operation;

		internal ConditionSelectorWithIndexProviding(Action<int> operation)
		{
			this.operation = operation;
		}

		public void For(int iterations)
		{
			Loops.ForWithIndexProviding.Execute(iterations, operation);
		}
		public void While(Func<bool> condition)
		{
			Loops.WhileWithIndexProviding.Execute(condition, operation);
		}
	}
}
