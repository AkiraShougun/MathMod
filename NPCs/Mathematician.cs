using math.Items;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;


namespace math.NPCs
{
    [AutoloadHead]
    public class Mathematician : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = 26;

            NPCID.Sets.ExtraFramesCount[Type] = 9;
            NPCID.Sets.AttackFrameCount[Type] = 5;
            NPCID.Sets.DangerDetectRange[Type] = 500;
            NPCID.Sets.AttackType[Type] = 1;
            NPCID.Sets.AttackTime[Type] = 45;
            NPCID.Sets.AttackAverageChance[Type] = 30;
            NPCID.Sets.HatOffsetY[Type] = -6;
        }
        public override void SetDefaults()
        {
            NPC.townNPC = true; 
			NPC.friendly = true; 
			NPC.width = 18;
			NPC.height = 40;
			NPC.aiStyle = 7;
			NPC.damage = 10;
			NPC.defense = 15;
			NPC.lifeMax = 250;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.knockBackResist = 0.5f;

			AnimationType = NPCID.Guide;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (NPC.CountNPCS(ModContent.NPCType<Mathematician>()) >= 1){
                return 0;
            }
            return SpawnCondition.OverworldDay.Chance * 1.0f;
        }

        public override string GetChat()
        {
            string[] chat = {
                "Hello there, fellow mathematician!",
                "Let X be an algebraic projective variety.",
                "Have you heard of the term 'the mathematical experience'? I am obsessed over it."
            };
            return Main.rand.Next(chat);
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = "Shop";
            button2 = "Quote";
        }

        public override void OnChatButtonClicked(bool firstButton, ref string shopName)
        {
            base.OnChatButtonClicked(firstButton, ref shopName);
            if (firstButton){
                shopName = "Shop";
            }
            else{
                Main.npcChatText = "Never gonna give you up.";
            }
        }

        public override void AddShops()
        {
            var npcShop = new NPCShop(Type, "Shop")
            .Add(new Item(ModContent.ItemType<ModularGroup>()) { shopCustomPrice = Item.buyPrice(copper: 15) });
            npcShop.Register();
        }
    }
}