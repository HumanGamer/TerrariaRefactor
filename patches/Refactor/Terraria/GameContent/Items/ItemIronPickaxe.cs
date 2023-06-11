using Terraria.ID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terraria.GameContent.Items
{
	public class ItemIronPickaxe : ItemDef
	{
		public ItemIronPickaxe() : base(ItemID.IronPickaxe)
		{
			useStyle = 1;
			useTurn = true;
			useAnimation = 20;
			useTime = 13;
			autoReuse = true;
			width = 24;
			height = 28;
			damage = 5;
			pick = 40;
			UseSound = SoundID.Item1;
			knockBack = 2f;
			value = 2000;
			melee = true;
		}
	}
}
