﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria.Enums;
using Terraria.ID;

namespace Terraria.GameContent.Items
{
	public class ItemMovementCore : ItemDef
	{
		public ItemMovementCore() : base(ItemID.MovementCore)
		{
			width = 34;
			height = 30;
			accessory = true;
			shoeSlot = 24;
			balloonSlot = 19;
			wingSlot = 29;
			rare = (int)ItemRarityColor.Purple11;
			value = Item.sellPrice(0, 15);
			hasVanityEffects = true;
		}
	}
}
