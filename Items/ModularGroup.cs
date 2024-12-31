using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace math.Items
{
    public class ModularGroup : ModItem{
        public override void SetDefaults()
        {
            Item.width = 15;
            Item.height = 15;
        }

        public override void AddRecipes(){
            CreateRecipe()
                .AddIngredient(ItemID.DirtBlock)
                .Register();
        }
    }
}

