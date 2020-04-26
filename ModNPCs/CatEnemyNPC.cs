using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AnimalWeaponsv2.Items.NPCs
{
    public class CatEnemyNPC : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cursed Ball of Yarn");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DemonEye];

        }
        public override void SetDefaults()
        {

            npc.width = 18;
            npc.height = 40;
            npc.lifeMax = 200;
            npc.damage = 30;
            npc.defense = 20;
            npc.HitSound = SoundID.NPCHit3;
            npc.DeathSound = SoundID.NPCDeath2;
            float v = npc.value - 10f;
            float v1 = npc.knockBackResist - 0.5f;
            npc.aiStyle = 2;
            aiType = NPCID.DemonEye;
            animationType = NPCID.DemonEye;
            banner = Item.NPCtoBanner(NPCID.None);

        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.1f;

        }
        public override void HitEffect(int hitDirection, double damage)
        {
            for (int i = 0; i < 10; i++)
            {
                int dustType = Main.rand.Next(139, 143); 
                int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
                Dust dust = Main.dust[dustIndex];
                dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
                dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
                float v = (dust.scale * -1f) + Main.rand.Next(-30, 31) * 0.01f;
            }





        }

        public override void NPCLoot()
        {
            if(Main.rand.Next(10) == 0)
            {
                Item.NewItem(npc.position, mod.ItemType("EssenceOfMeow"));
            }
            if(Main.hardMode)
            {
                Item.NewItem(npc.position, mod.ItemType("Meremeow"));
            }
        }
    }
    
}
