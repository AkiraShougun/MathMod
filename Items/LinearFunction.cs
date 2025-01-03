using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using math.Projectiles;
using math.Content.Rarities;

namespace math.Items {
    public class LinearFunction : ModItem {
    public override string Texture => "math/Items/Function";
        public override void SetDefaults() {
            Item.width = 58;
            Item.height = 106;

            Item.value = Item.buyPrice(gold: 1);
            Item.value = Item.sellPrice(silver: 75);
            
            Item.UseSound = SoundID.Item105;
            Item.useTime = 20;
			Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.HoldUp;

            Item.rare = ModContent.RarityType<MathRarity>();

            Item.DamageType = ModContent.GetInstance<MathDamage>();
            Item.damage = 17;
            Item.knockBack = 0;

            Item.shoot = ModContent.ProjectileType<LinearProjectile>();
            Item.shootSpeed = 20;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<FunctionBlank>())
                .AddIngredient(ItemID.Wood,5)
                .Register();
        }
    }
}