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
                tooltip.Text = "Использование Астроновы даёт Возвышение, увеличивающее все характеристики Астроновы на 4%. Максимум 3 стака";
                tooltip.OverrideColor = Color.LightGray;
            });
        }
        
        if (item.type == ModContent.ItemType<LuminousHallowPrism>())
        {
            ItemHelper.TranslateTooltip(tooltips, "StarsAbove: SetBonus1Info", tooltip =>
            {
                tooltip.Text = "Астронова активируется автоматически; Снижает расход энергии на 2% от длительности эффекта";
                tooltip.OverrideColor = Color.LightGray;
            });
        }
        
        if (item.type == ModContent.ItemType<RoyalSunrisePrism>())
        {
            ItemHelper.TranslateTooltip(tooltips, "StarsAbove: SetBonus1Info", tooltip =>
            {
                tooltip.Text = "Увеличивает атакующие характеристики Астроновы на 15%, когда здоровье 500 или выше";
                tooltip.OverrideColor = Color.LightGray;
            });
        }
        
        if (item.type == ModContent.ItemType<LucidDreamerPrism>())
        {
            ItemHelper.TranslateTooltip(tooltips, "StarsAbove: SetBonus1Info", tooltip =>
            {
                tooltip.Text = "Энергия Астроновы бесконечна, но она имеет перезарядку, которая зависит от расхода энергии";
                tooltip.OverrideColor = Color.LightGray;
            });
        }
    }
}