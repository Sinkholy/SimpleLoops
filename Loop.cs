using System;

using static SimpleLoops.Operations;

namespace SimpleLoops
{
	public static class Loop
	{
		public static LoopWithIndexer Iterate(WithIndexer operation)
		{
			return new LoopWithIndexer(operation);
		}
		public static LoopWithoutIndexer Iterate(WithOutIndexer operation)
		{
			return new LoopWithoutIndexer(operation);
		}
	}
	public class LoopWithIndexer
	{
		readonly WithIndexer operation;

		internal LoopWithIndexer(WithIndexer operation)
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
	public class LoopWithoutIndexer
	{
		readonly WithOutIndexer operation;

		internal LoopWithoutIndexer(WithOutIndexer operation)
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