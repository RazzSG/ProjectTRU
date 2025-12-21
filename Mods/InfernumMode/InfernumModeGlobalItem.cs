using System.Collections.Generic;
using CalamityMod.Items.SummonItems;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfernumModeGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Infernum != null && TRuConfig.Instance.InfernumModeLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (item.type == ModContent.ItemType<DecapoditaSprout>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Впадает в ярость за пределами грибных пустошей";
            });
        }
        
        if (item.type == ItemID.WormFood)
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText(" подземного " , " ");
            });
        }
        
        if (item.type == ItemID.BloodySpine)
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText(" подземного ", " ");
            });
        }
        
        if (item.type == ModContent.ItemType<Teratoma>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Впадает в ярость за пределами искажения";
            });
        }
        
        if (item.type == ModContent.ItemType<BloodyWormFood>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Впадает в ярость за пределами багрянца";
            });
        }
        
        if (item.type == ModContent.ItemType<Seafood>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Впадает в ярость за пределами вод сернистого моря";
            });
        }
        
        if (item.type == ModContent.ItemType<Abombination>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Впадает в ярость за пределами подземных джунглей";
            });
        }
        
        if (item.type == ModContent.ItemType<NecroplasmicBeacon>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Впадает в ярость за пределами подземелья\nНе расходуется";
            });
        }
    }
}
