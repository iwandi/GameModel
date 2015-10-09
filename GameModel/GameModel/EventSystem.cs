using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameModel
{
	// TODO: how to handle fall trouth
	// TODO: how to mark events as done and clear them
	public class EventSystem : ISystem
	{
		public Universe Universe { get; set; }

		public uint GetEventId(ushort nameSpace, ushort eventId)
		{
			return ((uint)nameSpace << 16) + (uint)eventId;
		}

		public void FireEvent(long entityId, uint eventId , params object[] args)
		{

		}

		public bool HasEvent(long entityId, uint eventId)
		{

		}

		public object[] GetEvent(long entityId, uint eventId)
		{

		}

		public void InvokeEvent(long entityId, uint eventId, string invokeMethod, object invokeTarget)
		{

		}

		public IEnumerable<IUpdateCall> ListUpdateCalls()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Type> ListComponentBaseTypes()
		{
			throw new NotImplementedException();
		}
	}

	public class EventBase
	{

	}
}
