using Terraria;
using Terraria.ModLoader;

public class MathDamage : DamageClass {
    public override bool ShowStatTooltipLine(Player player, string lineName) {
			// The four line names you can use are "Damage", "CritChance", "Speed", and "Knockback". All four cases default to true, and thus will be shown. For example...
			if (lineName == "Knockback")
				return false;
            return true;
    }
}

