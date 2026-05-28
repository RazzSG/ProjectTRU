using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.PathOfTerraria;

public class PathOfTerrariaGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "PathOfTerraria" && l.Name == "CriticalStrikeChance", _ =>
        {
            tooltips.ReplaceText("Critical Strike Chance", "Шанс критического удара");
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "PathOfTerraria" && l.Name == "Damage", _ =>
        {
            tooltips.ReplaceText("base", "базовый урон");
        });
        
        ItemHelper.TranslateTooltip(tooltips, l => l.Mod == "PathOfTerraria" && l.Name == "DamageBase", _ =>
        {
            tooltips.ReplaceText("базовый урон ед. стрелкового урона damage", "ед. оставшегося стрелкового урона");
            tooltips.ReplaceText("базовый урон ед. урона ближнего боя damage", "ед. оставшегося урона ближнего боя");
            tooltips.ReplaceText("базовый урон ед. магического урона damage", "ед. оставшегося магического урона");
            tooltips.ReplaceText("базовый урон ед. урона призывателя damage", "ед. оставшегося урона призывателя");
            tooltips.ReplaceText("базовый урон ед. урона damage", "ед. оставшегося урона");
            tooltips.ReplaceText("base ед. стрелкового урона damage", "ед. оставшегося стрелкового урона");
            tooltips.ReplaceText("base ед. урона ближнего боя damage", "ед. оставшегося урона ближнего боя");
            tooltips.ReplaceText("base ед. магического урона damage", "ед. оставшегося магического урона");
            tooltips.ReplaceText("base ед. урона призывателя damage", "ед. оставшегося урона призывателя");
        });
    }

    public override bool PreDrawTooltipLine(Item item, DrawableTooltipLine line, ref int yOffset)
    {
        if (line.Mod == "PathOfTerraria" && line.Name == "ItemLevel")
        {
            yOffset = 2;
            return true;
        }
        return base.PreDrawTooltipLine(item, line, ref yOffset);
    }
}