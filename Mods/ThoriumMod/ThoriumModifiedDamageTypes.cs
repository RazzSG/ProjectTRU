using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using ThoriumMod;

namespace CalamityRuTranslate.Mods.ThoriumMod;

public class ThoriumModifiedDamageTypes : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Thorium != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, "Damage", tooltip =>
        {
            if (item.CountsAsClass<BardDamage>() || item.CountsAsClass<HealerDamage>() ||
                item.CountsAsClass<HealerTool>() || item.CountsAsClass<HealerToolDamageHybrid>())
            {
                if (TRuConfig.Instance.ColoredDamageTypes)
                    tooltip.OverrideColor = new Color(255, 138, 248);
            }
        });
    }
}