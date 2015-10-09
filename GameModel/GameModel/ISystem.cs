using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameModel
{
	public interface ISystem
	{
		Universe Universe { get; set; }

		// TODO : name this better
		// TODO : Use atributes ?
		IEnumerable<IUpdateCall> ListUpdateCalls();		
		IEnumerable<Type> ListComponentBaseTypes();
	}

	public interface IComponentSystem<T> : ISystem  where T : IComponent
	{
		long GetEntityId(T component);

		T GetComponent(long entityId);
		T[] GetComponents(long eneityId);
		void GetComponents(long eneityId, ICollection<T> list);
		IEnumerable<T> ListComponents(long entityId);
	}

	// TODO : name this better
	public interface IUpdateCall
	{
		// TODO : list system this update cdall depends on
		//		this should allow us to build a dependency awave update loop

		void Update();
	}
}
