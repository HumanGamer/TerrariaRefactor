using Microsoft.Xna.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria.Audio;
using Terraria.ID;
using Terraria.UI;
using Terraria.Utilities;
using static Terraria.GameContent.Animations.Actions.NPCs;
using static Terraria.GameContent.Bestiary.SortingSteps;
using static Terraria.GameContent.Prefixes.PrefixLegacy;

namespace Terraria.GameContent.Items
{
	public class ItemDef
	{
		public readonly int itemID;
		public int width;
		public int height;

		public bool flame;
		public bool mech;
		public int tileWand;
		public bool wornArmor;
		public byte dye;
		public int fishingPole;
		public int bait;
		public short makeNPC;
		public bool expert;
		public short hairDye;
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
		public int createTile;
		public int createWall;
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
		public float scale;
		public LegacySoundStyle UseSound;
		public int defense;
		public int headSlot;
		public int bodySlot;
		public int legSlot;
		public sbyte handOnSlot;
		public sbyte handOffSlot;
		public sbyte backSlot;
		public sbyte frontSlot;
		public sbyte shoeSlot;
		public sbyte waistSlot;
		public sbyte wingSlot;
		public sbyte shieldSlot;
		public sbyte neckSlot;
		public sbyte faceSlot;
		public sbyte balloonSlot;
		public sbyte beardSlot;
		public int stringColor;
		public int rare;
		public int shoot;
		public float shootSpeed;
		public int ammo;
		public bool notAmmo;
		public int useAmmo;
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
		public int mountType;
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
			Reset();

			itemID = id;
			_items.Add(id, this);
		}

		private void Reset()
		{
			sentry = false;
			hasVanityEffects = false;
			DD2Summon = false;
			expert = false;
			fishingPole = 0;
			bait = 0;
			hairDye = -1;
			makeNPC = 0;
			dye = 0;
			paint = 0;
			paintCoating = 0;
			tileWand = -1;
			notAmmo = false;
			crit = 0;
			mech = false;
			flame = false;
			reuseDelay = 0;
			melee = false;
			magic = false;
			ranged = false;
			summon = false;
			placeStyle = 0;
			buffTime = 0;
			buffType = 0;
			mountType = -1;
			cartTrack = false;
			material = false;
			noWet = false;
			vanity = false;
			mana = 0;
			channel = false;
			manaIncrease = 0;
			noMelee = false;
			noUseGraphic = false;
			lifeRegen = 0;
			shootSpeed = 0f;
			alpha = 0;
			ammo = AmmoID.None;
			useAmmo = AmmoID.None;
			autoReuse = false;
			accessory = false;
			axe = 0;
			healMana = 0;
			bodySlot = -1;
			legSlot = -1;
			headSlot = -1;
			potion = false;
			color = default(Color);
			glowMask = -1;
			consumable = false;
			chlorophyteExtractinatorConsumable = false;
			createTile = -1;
			createWall = -1;
			damage = -1;
			defense = 0;
			hammer = 0;
			healLife = 0;
			holdStyle = 0;
			knockBack = 0f;
			maxStack = 1;
			pick = 0;
			rare = 0;
			scale = 1f;
			shoot = 0;
			tileBoost = 0;
			useStyle = 0;
			UseSound = null;
			useTime = 100;
			useAnimation = 100;
			value = 0;
			useTurn = false;
			handOnSlot = -1;
			handOffSlot = -1;
			backSlot = -1;
			frontSlot = -1;
			shoeSlot = -1;
			waistSlot = -1;
			wingSlot = -1;
			shieldSlot = -1;
			neckSlot = -1;
			faceSlot = -1;
			balloonSlot = -1;
			beardSlot = -1;
			uniqueStack = false;
			shootsEveryUse = false;
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
