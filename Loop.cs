using System;

namespace SimpleLoops
{
	public class Loop
	{
		public static ForLoop Repeat(int iterations)
		{
			return new ForLoop(iterations);
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
		}
	}
}
