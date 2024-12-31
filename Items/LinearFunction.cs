using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Audio;
using math.Projectiles;

namespace math.Items {
    public class LinearFunction : ModItem {
        public override void SetDefaults() {
            Item.width = 58;
            Item.height = 106;

            Item.value = Item.buyPrice(gold: 1);
            Item.value = Item.sellPrice(silver: 75);
            
            Item.UseSound = SoundID.Item105;
            Item.useTime = 50;
			Item.useAnimation = 50;
            Item.useStyle = ItemUseStyleID.HoldUp;

            Item.rare = ItemRarityID.Master;

            Item.DamageType = ModContent.GetInstance<MathDamage>();
            Item.damage = 100;
            Item.knockBack = 0;

            Item.shoot = ModContent.ProjectileType<LinearProjectile>();
            Item.shootSpeed = 20;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .Register();
        }
    }
}