using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AnimalWeaponsv2.Items
{
    public class EssenceOfMeow : ModItem
    {
        private const int V = 12;
        private const int V1 = 12;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Essence Of Meow");

        }
        public override void SetDefaults()
        {
            item.width = V;
            item.height = V1;
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(silver: 50);
            item.maxStack = 999;
        }
    }
}
