using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameModel
{
	public class GenericSystem : ISystem /*, IComponentSystem<IComponent>*/
	{
		public Universe Universe { get; set; }

		public IEnumerable<IUpdateCall> ListUpdateCalls()
		{
			yield break;
		}

		public IEnumerable<Type> ListComponentBaseTypes()
		{
			yield break;
		}
	}
}
