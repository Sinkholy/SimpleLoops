using System;

namespace SimpleLoops.ConditionSelectors
{
	public class ConditionSelector : IConditionSelector
	{
		readonly Action operation;

		internal ConditionSelector(Action operation)
		{
			this.operation = operation;
		}

		public void For(int iterations)
		{
			Loops.For.Execute(iterations, operation);
		}
		public void While(Func<bool> condition)
		{
			Loops.While.Execute(condition, operation);
		}
	}
}
