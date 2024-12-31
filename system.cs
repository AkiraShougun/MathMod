using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace math
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class System : ModSystem
	{
        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ItemID.Zenith,1);
            recipe.AddIngredient(ItemID.Wood,10);

            recipe.Register();
        }
    }
}
