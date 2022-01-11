using System;

namespace SimpleLoops
{
	public class Loop
	{
		public static ForLoop Repeat(int iterations)
		{
			return new ForLoop(iterations);
		}
		public static WhileLoop While(Func<bool> condition)
		{
			return new WhileLoop(condition);
		}

		public class ForLoop
		{
			readonly int iterations;
			int currentIteration;

			public ForLoop(int iterations)
			{
				this.iterations = iterations;
				currentIteration = 0;
			}

			public void Operation(Action<int> operation)
			{
				for (; currentIteration < iterations; currentIteration++)
				{
					operation(currentIteration);
				}
			}
			public void Operation(Action operation)
			{
				for (; currentIteration < iterations; currentIteration++)
				{
					operation();
				}
			}
		}
		public class WhileLoop
		{
			readonly Func<bool> condition;

			public WhileLoop(Func<bool> condition)
			{
				this.condition = condition;
			}

			public void Operation(Action operation)
			{
				bool conditionMet = condition();
				while (conditionMet)
				{
					operation();
				}
			}
		}
	}
}
