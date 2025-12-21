using System.Collections.Generic;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla;

public class AccessoryCritChanceTooltip : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (item.prefix is 67 or 68)
        {
            ItemHelper.TranslateTooltip(tooltips, l => l.FullName == "Terraria/PrefixAccCritChance", _ =>
            {
                tooltips.ReplaceText(Lang.tip[5].Value, Lang.tip[41].Value);
            });
        }
    }
}