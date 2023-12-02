using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.tModLoader;

public class DeveloperTooltipTranslation : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.ModItem?.Mod == ModInstances.TModLoader;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, "DeveloperSetNote", tooltip =>
        {
            tooltip.Text = "Предмет разработчика Jofairden";
        });
    }
}