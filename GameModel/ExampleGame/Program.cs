using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using GameModel;

namespace ExampleGame
{
	class Program
	{
		static void Main(string[] args)
		{
			Universe universe = new Universe();

			TagSystem<EntityTags> tagSystem = new TagSystem<EntityTags>();
			universe.AddSystem(tagSystem);

			tagSystem.SetTag(1, EntityTags.Tomato);
			tagSystem.SetTag(1, EntityTags.Onion);

			Console.WriteLine(tagSystem.HasTag(1, EntityTags.Cheese) + " == false");
			Console.WriteLine(tagSystem.HasTag(1, EntityTags.Onion) + " == true");

			tagSystem.ClearTag(1, EntityTags.Onion);

			Console.WriteLine(tagSystem.HasTag(1, EntityTags.Onion) + " == false");			
			Console.WriteLine(tagSystem.GetTag(1));

			Console.ReadLine();
		}
	}

	[Flags]
	enum EntityTags
	{
		Tomato,
		Onion,
		Cheese
	}
}
