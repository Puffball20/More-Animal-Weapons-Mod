using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace AnimalWeaponsv2.Items.Weapons
{
    public class Meremeow : ModItem
    {
        private const int Value = 10;

        public override void SetDefaults()
        {
            item.Size = new Vector2(Value);
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(gold: 1);

            item.autoReuse = true;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;

            item.melee = true;
            item.damage = 50;
            item.knockBack = 6f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<EssenceOfMeow>(), 6);
            
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}