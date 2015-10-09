using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameModel
{
	public class EnumFlagsUtil
	{
		// TODO : order for mot likly use cases
		// TODO : use runtime compiled code to optimize this 
		//		http://stackoverflow.com/questions/10387095/cast-int-to-generic-enum-in-c-sharp
		public static T AddFlag<T>(T value, T operant) where T : struct
		{
			Type enumType = typeof(T);
			Type valueType = Enum.GetUnderlyingType(enumType);

			if (valueType.Equals(typeof(byte)))
			{
				byte valueTyped = System.Convert.ToByte(value);
				byte opTyped = System.Convert.ToByte(operant);
				return (T)Enum.ToObject(enumType, valueTyped | opTyped);
			}
			else if (valueType.Equals(typeof(short)))
			{
				short valueTyped = System.Convert.ToInt16(value);
				short opTyped = System.Convert.ToInt16(operant);
				return (T)Enum.ToObject(enumType, valueTyped | opTyped);
			}
			else if (valueType.Equals(typeof(ushort)))
			{
				ushort valueTyped = System.Convert.ToUInt16(value);
				ushort opTyped = System.Convert.ToUInt16(operant);
				return (T)Enum.ToObject(enumType, valueTyped | opTyped);
			}
			else if (valueType.Equals(typeof(int)))
			{
				int valueTyped = System.Convert.ToInt32(value);
				int opTyped = System.Convert.ToInt32(operant);
				return (T)Enum.ToObject(enumType, valueTyped | opTyped);
			}
			else if (valueType.Equals(typeof(uint)))
			{
				uint valueTyped = System.Convert.ToUInt32(value);
				uint opTyped = System.Convert.ToUInt32(operant);
				return (T)Enum.ToObject(enumType, valueTyped | opTyped);
			}
			else if (valueType.Equals(typeof(long)))
			{
				long valueTyped = System.Convert.ToInt64(value);
				long opTyped = System.Convert.ToInt64(operant);
				return (T)Enum.ToObject(enumType, valueTyped | opTyped);
			}
			else if (valueType.Equals(typeof(ulong)))
			{
				ulong valueTyped = System.Convert.ToUInt64(value);
				ulong opTyped = System.Convert.ToUInt64(operant);
				return (T)Enum.ToObject(enumType, valueTyped | opTyped);
			}
			throw new ArgumentException();
		}

		public static T RemoveFlag<T>(T value, T operant) where T : struct
		{
			Type enumType = typeof(T);
			Type valueType = Enum.GetUnderlyingType(enumType);

			if (valueType.Equals(typeof(byte)))
			{
				byte valueTyped = System.Convert.ToByte(value);
				byte opTyped = System.Convert.ToByte(operant);
				return (T)Enum.ToObject(enumType, valueTyped & ~opTyped);
			}
			else if (valueType.Equals(typeof(short)))
			{
				short valueTyped = System.Convert.ToInt16(value);
				short opTyped = System.Convert.ToInt16(operant);
				return (T)Enum.ToObject(enumType, valueTyped & ~opTyped);
			}
			else if (valueType.Equals(typeof(ushort)))
			{
				ushort valueTyped = System.Convert.ToUInt16(value);
				ushort opTyped = System.Convert.ToUInt16(operant);
				return (T)Enum.ToObject(enumType, valueTyped & ~opTyped);
			}
			else if (valueType.Equals(typeof(int)))
			{
				int valueTyped = System.Convert.ToInt32(value);
				int opTyped = System.Convert.ToInt32(operant);
				return (T)Enum.ToObject(enumType, valueTyped & ~opTyped);
			}
			else if (valueType.Equals(typeof(uint)))
			{
				uint valueTyped = System.Convert.ToUInt32(value);
				uint opTyped = System.Convert.ToUInt32(operant);
				return (T)Enum.ToObject(enumType, valueTyped & ~opTyped);
			}
			else if (valueType.Equals(typeof(long)))
			{
				long valueTyped = System.Convert.ToInt64(value);
				long opTyped = System.Convert.ToInt64(operant);
				return (T)Enum.ToObject(enumType, valueTyped & ~opTyped);
			}
			else if (valueType.Equals(typeof(ulong)))
			{
				ulong valueTyped = System.Convert.ToUInt64(value);
				ulong opTyped = System.Convert.ToUInt64(operant);
				return (T)Enum.ToObject(enumType, valueTyped & ~opTyped);
			}
			throw new ArgumentException();
		}

		public static bool HasFlag<T>(T value, T requirement) where T : struct
		{
			Type enumType = typeof(T);
			Type valueType = Enum.GetUnderlyingType(enumType);

			if (valueType.Equals(typeof(byte)))
			{
				byte valueTyped = System.Convert.ToByte(value);
				byte opTyped = System.Convert.ToByte(requirement);
				return (valueTyped & opTyped) == opTyped;
			}
			else if (valueType.Equals(typeof(short)))
			{
				short valueTyped = System.Convert.ToInt16(value);
				short opTyped = System.Convert.ToInt16(requirement);
				return (valueTyped & opTyped) == opTyped;
			}
			else if (valueType.Equals(typeof(ushort)))
			{
				ushort valueTyped = System.Convert.ToUInt16(value);
				ushort opTyped = System.Convert.ToUInt16(requirement);
				return (valueTyped & opTyped) == opTyped;
			}
			else if (valueType.Equals(typeof(int)))
			{
				int valueTyped = System.Convert.ToInt32(value);
				int opTyped = System.Convert.ToInt32(requirement);
				return (valueTyped & opTyped) == opTyped;
			}
			else if (valueType.Equals(typeof(uint)))
			{
				uint valueTyped = System.Convert.ToUInt32(value);
				uint opTyped = System.Convert.ToUInt32(requirement);
				return (valueTyped & opTyped) == opTyped;
			}
			else if (valueType.Equals(typeof(long)))
			{
				long valueTyped = System.Convert.ToInt64(value);
				long opTyped = System.Convert.ToInt64(requirement);
				return (valueTyped & opTyped) == opTyped;
			}
			else if (valueType.Equals(typeof(ulong)))
			{
				ulong valueTyped = System.Convert.ToUInt64(value);
				ulong opTyped = System.Convert.ToUInt64(requirement);
				return (valueTyped & opTyped) == opTyped;
			}
			throw new ArgumentException();
		}
	}
}
