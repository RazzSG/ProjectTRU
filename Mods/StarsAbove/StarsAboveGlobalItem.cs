using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Microsoft.Xna.Framework;
using StarsAbove.Items.Prisms;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.StarsAbove;

public partial class StarsAboveGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ModifyDamageTypes(item, tooltips);

        if (item.type == ModContent.ItemType<AuricExaltPrism>())
        {
            ItemHelper.TranslateTooltip(tooltips, "StarsAbove: SetBonus1Info", tooltip =>
            {
                tooltip.Text = "После использования Астроновы вы получаете Возвышение, увеличивающее все её характеристики на 4% (максимум 3 стака)";
                tooltip.OverrideColor = Color.LightGray;
            });
        }
        
        if (item.type == ModContent.ItemType<LuminousHallowPrism>())
        {
            ItemHelper.TranslateTooltip(tooltips, "StarsAbove: SetBonus1Info", tooltip =>
            {
                tooltip.Text = "Астронова активируется автоматически; снижает расход энергии на 2% от длительности эффекта";
                tooltip.OverrideColor = Color.LightGray;
            });
        }
        
        if (item.type == ModContent.ItemType<RoyalSunrisePrism>())
        {
            ItemHelper.TranslateTooltip(tooltips, "StarsAbove: SetBonus1Info", tooltip =>
            {
                tooltip.Text = "Атакующие характеристики Астроновы увеличиваются на 15%, если здоровье не ниже 500";
                tooltip.OverrideColor = Color.LightGray;
            });
        }
        
        if (item.type == ModContent.ItemType<LucidDreamerPrism>())
        {
            ItemHelper.TranslateTooltip(tooltips, "StarsAbove: SetBonus1Info", tooltip =>
            {
                tooltip.Text = "Энергия Астроновы неограниченна, но между применениями действует перезарядка, зависящая от расхода энергии";
                tooltip.OverrideColor = Color.LightGray;
            });
        }
    }
}