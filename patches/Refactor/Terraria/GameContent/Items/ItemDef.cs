using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria.Audio;
using Terraria.ID;
using Terraria.UI;
using Terraria.Utilities;

namespace Terraria.GameContent.Items
{
	public class ItemDef
	{
		public readonly int itemID;
		public int width;
		public int height;

		public bool flame;
		public bool mech;
		public int tileWand = -1;
		public bool wornArmor;
		public byte dye;
		public int fishingPole = 1;
		public int bait;
		public short makeNPC;
		public bool expert;
		public short hairDye = -1;
		public byte paint;
		public byte paintCoating;
		public int holdStyle;
		public int useStyle;
		public bool channel;
		public bool accessory;
		public int useAnimation;
		public int useTime;
		public int maxStack;
		public int pick;
		public int axe;
		public int hammer;
		public int tileBoost;
		public int createTile = -1;
		public int createWall = -1;
		public int placeStyle;
		public int damage;
		public float knockBack;
		public int healLife;
		public int healMana;
		public bool potion;
		public bool consumable;
		public bool autoReuse;
		public bool useTurn;
		public Color color;
		public int alpha;
		public short glowMask;
		public float scale = 1f;
		public LegacySoundStyle UseSound;
		public int defense;
		public int headSlot = -1;
		public int bodySlot = -1;
		public int legSlot = -1;
		public sbyte handOnSlot = -1;
		public sbyte handOffSlot = -1;
		public sbyte backSlot = -1;
		public sbyte frontSlot = -1;
		public sbyte shoeSlot = -1;
		public sbyte waistSlot = -1;
		public sbyte wingSlot = -1;
		public sbyte shieldSlot = -1;
		public sbyte neckSlot = -1;
		public sbyte faceSlot = -1;
		public sbyte balloonSlot = -1;
		public sbyte beardSlot = -1;
		public int stringColor;
		public int rare;
		public int shoot;
		public float shootSpeed;
		public int ammo = AmmoID.None;
		public bool notAmmo;
		public int useAmmo = AmmoID.None;
		public int lifeRegen;
		public int manaIncrease;
		public int mana;
		public bool noUseGraphic;
		public bool noMelee;
		public int value;
		public bool vanity;
		public bool material;
		public bool noWet;
		public int buffType;
		public int buffTime;
		public int mountType = -1;
		public bool cartTrack;
		public bool uniqueStack;
		public bool shootsEveryUse;
		public bool chlorophyteExtractinatorConsumable;
		public bool DD2Summon;
		public int crit;
		public bool melee;
		public bool magic;
		public bool ranged;
		public bool summon;
		public bool sentry;
		public int reuseDelay;

		[Old("This is used to allow items to be discerned as vanity even if they didn't have visual slots to poll against")]
		public bool hasVanityEffects;

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
