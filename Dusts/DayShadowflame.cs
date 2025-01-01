using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace math.Dusts {
    public class DayShadowflame : ModDust {
        public static readonly Color OverrideColor = new(0xff, 0xa5, 0);
        public override void SetStaticDefaults()
        {
            Dust.CloneDust(DustID.ShadowbeamStaff);
        }
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.color = OverrideColor;
        }
    }
}