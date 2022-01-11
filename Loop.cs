using System;

namespace SimpleLoops
{
	public class Loop
	{
		public static ConditionSelector Repeat(Action operation)
		{
			return new ConditionSelector(operation);
		}
		public static ConditionSelector Repeat(Action<int> operation)
		{
			return new ConditionSelector(operation);
		}

		public class ConditionSelector
		{
			readonly bool shouldProvideIndex;
			readonly Action operation;
			readonly Action<int> operationWithIndex;

			internal ConditionSelector(Action operation)
			{
				shouldProvideIndex = false;
				this.operation = operation;
			}
			internal ConditionSelector(Action<int> operation)
			{
				shouldProvideIndex = true;
				operationWithIndex = operation;
			}

			public void For(int iterations)
			{
				if (shouldProvideIndex)
				{
					ForLoop.ExecuteWithProvidingIndexer(iterations, operationWithIndex);
				}
				else
				{
					ForLoop.Execute(iterations, operation);
				}
			}
			public void While(Func<bool> condition)
			{
				if (shouldProvideIndex)
				{
					WhileLoop.ExecuteWithProvidingIndexer(condition, operationWithIndex);
				}
				else
				{
					WhileLoop.Execute(condition, operation);
				}
			}
		}
		internal static class ForLoop
		{
			internal static void ExecuteWithProvidingIndexer(int iterations, Action<int> operation)
			{
				for (int currentIteration = 0; currentIteration < iterations; currentIteration++)
				{
					operation(currentIteration);
				}
			}
			internal static void Execute(int iterations, Action operation)
			{
				for (int currentIteration = 0; currentIteration < iterations; currentIteration++)
				{
					operation();
				}
			}
		}
		internal static class WhileLoop
		{
			internal static void Execute(Func<bool> condition, Action operation)
			{
				bool conditionMet = condition();
				while (conditionMet)
				{
					operation();
				}
			}
			internal static void ExecuteWithProvidingIndexer(Func<bool> condition, Action<int> operation)
			{
				int iteration = 0;
				bool conditionMet = condition();
				while (conditionMet)
				{
					operation(iteration++);
				}
			}
		}
	}

}
