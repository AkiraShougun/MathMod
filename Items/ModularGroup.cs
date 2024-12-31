using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace math.Items {
    [AutoloadEquip(EquipType.HandsOn)]
    public class ModularGroup : ModItem {
        public static readonly float mathDamageMult = 0.15f;
        public static readonly float mathCritMult = 0.35f;
        public override void SetDefaults() {
            Item.width = 15;
            Item.height = 15;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(ModContent.GetInstance<MathDamage>()) += mathDamageMult;
        }

        public override void AddRecipes() {
            CreateRecipe()
                .AddIngredient(ItemID.DirtBlock, 1)
                .Register();
        }
    }
}

