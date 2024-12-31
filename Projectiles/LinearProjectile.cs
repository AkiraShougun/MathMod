using math.Dusts;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace math.Projectiles {
    public class LinearProjectile : ModProjectile {
        public override void SetDefaults() {
            Projectile.CloneDefaults(ProjectileID.Bullet);
            // Projectile.light = 1.0f;
            Projectile.aiStyle = 0;
            Projectile.extraUpdates = 20;
            Projectile.timeLeft = 120;
        }
        public override bool PreAI()
        {
            if (Main.dayTime == false) {
                Dust.NewDust(Projectile.Center, 1, 1, DustID.ShadowbeamStaff, 0, 0, 1, default, 1.5f);
            } else {
                Dust.NewDust(Projectile.Center, 1, 1, ModContent.DustType<DayShadowflame>(), 0, 0, 1, default, 1.5f);
            }
            return false;
        }
        public override void OnKill(int timeLeft)
        {
            Collision.HitTiles(Projectile.position, Projectile.velocity, Projectile.width, Projectile.height);
        }
    }
}