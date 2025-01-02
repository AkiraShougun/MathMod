using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace math.Content.Rarities
{
	public class MathRarity : ModRarity
	{
		public override Color RarityColor => new Color(5, (byte)(Main.DiscoG / 0.75f), 255);
	}
}