using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace math.Content.Rarities
{
	public class MathRarity : ModRarity
	{
		public override Color RarityColor => Color.Lerp(new Color(5, 255, 255), new Color(5, 166, 255), Main.masterColor);
	}
}