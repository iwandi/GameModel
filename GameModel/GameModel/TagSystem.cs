using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameModel
{
	public class TagSystem<T> : ISystem where T : struct //, IComponentSystem<TagComponent>
	{
		public Universe Universe { get; set; }

		Dictionary<long, T> tagList = new Dictionary<long, T>();
		
		public void SetTag(long entityId, T tag, bool overrideTag = false)
		{
			T entityTag;
			if (tagList.TryGetValue(entityId, out entityTag) )
			{
				if (overrideTag && !entityId.Equals(tag))
				{
					tagList[entityId] = tag;
				}
				else
				{
					tagList[entityId] = EnumFlagsUtil.AddFlag<T>(entityTag, tag);
				}
			}
			else
			{
				tagList.Add(entityId, tag);
			}
		}

		public void ClearTag(long entityId, T tag)
		{
			T entityTag;
			if (tagList.TryGetValue(entityId, out entityTag))
			{
				tagList[entityId] = EnumFlagsUtil.RemoveFlag<T>(entityTag, tag);
			}
		}

		public T GetTag(long entityId)
		{
			T entityTag;
			if (tagList.TryGetValue(entityId, out entityTag))
			{
				return entityTag;
			}
			return default(T);
		}

		public bool HasTag(long entityId, T tag)
		{
			T entityTag;
			if (tagList.TryGetValue(entityId, out entityTag))
			{
				return EnumFlagsUtil.HasFlag<T>(entityTag, tag);
			}
			return false;
		}

		public IEnumerable<IUpdateCall> ListUpdateCalls()
		{
			yield break;
		}

		public IEnumerable<Type> ListComponentBaseTypes()
		{
			yield break;
		}
	}

	/*public class TagComponent : IComponent
	{

	}*/
}
