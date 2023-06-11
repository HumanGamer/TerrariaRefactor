using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria.Audio;
using Terraria.ID;

namespace Terraria.GameContent.Items
{
	public class ItemDef
	{
		public readonly int itemID;
		public int useStyle;
		public bool useTurn;
		public int useAnimation;
		public int useTime;
		public bool autoReuse;
		public int width;
		public int height;
		public int damage;
		public int pick;
		public LegacySoundStyle UseSound;
		public float knockBack;
		public int value;
		public bool melee;

		public ItemDef(int id)
		{
			itemID = id;
			_items.Add(id, this);
		}

		private static Dictionary<int, ItemDef> _items = new();
		private static bool _initialized;

		public static ItemDef Get(int id)
		{
			InitItems(); // TODO: Call this in a better place

			if (_items.ContainsKey(id))
				return _items[id];

			return null;
		}

		public static ItemIronPickaxe ironPickaxe;

		public static void InitItems()
		{
			if (_initialized)
				return;

			_initialized = true;

			ironPickaxe = new ItemIronPickaxe();
		}
	}
}
