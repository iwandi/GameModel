using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameModel
{
	public class TypeUtil
	{
		static Dictionary<Type, List<Type>> typeCache = new Dictionary<Type, List<Type>>();

		public static IEnumerable<Type> ListTypesAndInterfaces(Type t)
		{
			List<Type> subTypeList;
			if (!typeCache.TryGetValue(t, out subTypeList))
			{
				subTypeList = new List<Type>();
				foreach (Type subType in CreateListTypesAndInterfaces(t))
				{
					if (!subTypeList.Contains(subType))
					{
						subTypeList.Add(subType);
					}
				}

				typeCache.Add(t, subTypeList);
			}

			return subTypeList;
		}

		static IEnumerable<Type> CreateListTypesAndInterfaces(Type t)
		{
			while (t != typeof(object))
			{
				yield return t;

				foreach (Type subType in t.GetInterfaces())
				{
					yield return subType;
				}

				Type b = t.BaseType;
				if (b == t)
				{
					break;
				}
				t = b;
			}
		}
	}
}
