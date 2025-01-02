using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ID;
using math.Content.Rarities;

namespace math.Items {
    [AutoloadEquip(EquipType.HandsOn)]
    public class ModularGroup : ModItem {
        public static readonly float mathDamageMult = 0.15f;
        public static readonly float mathCritMult = 0.35f;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(mathDamageMult, mathCritMult);

        public override void SetDefaults() {
            Item.width = 15;
            Item.height = 15;
            Item.accessory = true;
            Item.rare = ModContent.RarityType<MathRarity>();
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

