using System;

namespace SimpleLoops.ConditionSelectors
{
	public interface IConditionSelector
	{
		public void For(int iterations);
		public void While(Func<bool> condition);
	}
}
