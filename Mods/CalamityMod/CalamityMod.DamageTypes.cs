using System.Collections.Generic;
using CalamityMod;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public partial class CalamityModGlobalItem
{
    public void ModifyDamageTypes(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, "Damage", tooltip =>
        {
            if (item.CountsAsClass<RogueDamageClass>())
            {
                if (TRuConfig.Instance.ColoredDamageTypes)
                    tooltip.OverrideColor = new Color(255, 184, 108);
            }
        });
    }
}