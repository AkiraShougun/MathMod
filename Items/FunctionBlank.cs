using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace math.Items {
    public class FunctionBlank : ModItem {
        public override string Texture => "math/Items/Function";
        public override void SetDefaults() {
            Item.width = 58;
            Item.height = 106;

            Item.value = Item.buyPrice(gold: 1);
            Item.value = Item.sellPrice(silver: 75);
            
            Item.UseSound = SoundID.Item92;
            Item.useTime = 20;
			Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.HoldUp;

            Item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .Register();
        }
    }
}