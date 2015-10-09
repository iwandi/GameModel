using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameModel
{
	public class Universe
	{
		List<ISystem> systems = new List<ISystem>();
		Dictionary<Type, ISystem> typeLookup = new Dictionary<Type, ISystem>();
		List<IUpdateCall> updateCalls = new List<IUpdateCall>();

		public void AddSystem(ISystem system)
		{
			systems.Add(system);
			system.Universe = this;

			// TODO : this should be  configurable
			foreach (Type t in system.ListComponentBaseTypes())
			{
				if (!typeLookup.ContainsKey(t))
				{
					typeLookup.Add(t, system);
				}
				else
				{
					// TODO : Debug output to indicate this type is overshadows by a diffrent system
				}
			}

			RebuildUpdateCalls();
		}

		public void RemoveSystem(ISystem system)
		{
			foreach (Type t in system.ListComponentBaseTypes())
			{
				ISystem typeSys;
				if (typeLookup.TryGetValue(t, out typeSys) && typeSys == system)
				{
					typeLookup.Remove(t);
					// TODO : overshadod systems will not take over serving this type
				}
			}

			systems.Remove(system);
			system.Universe = null;

			RebuildUpdateCalls();
		}

		// TODO : why not rebuild all system related concepts
		void RebuildUpdateCalls()
		{
			// TODO : update calls
		}

		public void Update(float time)
		{
			// TODO: allow systems to have more dynamic update invokation
			// TODO System to system update ?
			for (int i = 0; i < updateCalls.Count; i++)
			{
				updateCalls[i].Update();
			}
		}

		public IComponentSystem<T> GetComponentSystem<T>() where T : IComponent
		{
			foreach(Type t in TypeUtil.ListTypesAndInterfaces(typeof(T)))
			{
				ISystem system;
				if (typeLookup.TryGetValue(typeof(T), out system))
				{
					return (IComponentSystem<T>)system;
				}
			}			
			return null;
		}

		public T GetComponent<T>(long entityId) where T : IComponent
		{
			return GetComponentSystem<T>().GetComponent(entityId);
		}

		public T[] GetComponents<T>(long entityId) where T : IComponent
		{
			return GetComponentSystem<T>().GetComponents(entityId);
		}

		public void GetComponents<T>(long eneityId, ICollection<T> list) where T : IComponent
		{
			GetComponentSystem<T>().GetComponents(eneityId, list);
		}

		public IEnumerable<T> ListComponents<T>(long entityId) where T : IComponent
		{
			return GetComponentSystem<T>().ListComponents(entityId);
		}
	}
}
