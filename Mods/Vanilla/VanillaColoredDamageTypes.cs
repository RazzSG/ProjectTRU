using System.Collections.Generic;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla;

public class VanillaColoredDamageTypes : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (!TRuConfig.Instance.ColoredDamageTypes)
            return;

        ItemHelper.TranslateTooltip(tooltips, "Damage", tooltip =>
        {
            if (item.CountsAsClass<MeleeDamageClass>() && (tooltip.Text.Contains(Language.GetTextValue("LegacyTooltip.2")) || tooltip.Text.Contains("ед. истинного урона ближнего боя")))
                tooltip.OverrideColor = new Color(255, 85, 85);

            else if (item.CountsAsClass<MagicDamageClass>() && tooltip.Text.Contains(Language.GetTextValue("LegacyTooltip.4")))
                tooltip.OverrideColor = new Color(189, 147, 249);

            else if (item.CountsAsClass<RangedDamageClass>() && tooltip.Text.Contains(Language.GetTextValue("LegacyTooltip.3")))
                tooltip.OverrideColor = new Color(80, 250, 123);

            else if ((item.CountsAsClass<SummonDamageClass>() || item.CountsAsClass<SummonMeleeSpeedDamageClass>()) && tooltip.Text.Contains(Language.GetTextValue("LegacyTooltip.53")))
                tooltip.OverrideColor = new Color(241, 250, 140);
        });
    }
}