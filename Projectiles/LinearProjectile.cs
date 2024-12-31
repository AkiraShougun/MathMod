using System.Drawing;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace math.Projectiles {
    public class LinearProjectile : ModProjectile {
        public override void SetDefaults() {
            Projectile.CloneDefaults(ProjectileID.Bullet);
            Projectile.light = 1.0f;
            Projectile.aiStyle = 0;
            Projectile.extraUpdates = 20;
        }
        public override bool PreAI()
        {
            Dust.NewDust(Projectile.Center, 1, 1, DustID.ShadowbeamStaff, 0, 0, 1, default, 1.0f);
            return false;
        }
    }
}