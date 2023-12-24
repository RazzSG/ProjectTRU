using System.Collections.Generic;
using CalamityMod.Items.SummonItems;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode;

public class InfernumModeGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && ModInstances.Infernum != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        if (item.type == ModContent.ItemType<DecapoditaSprout>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Входит в ярость за пределами грибных пустошей";
            });
        }
        else if (item.type == ItemID.WormFood)
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText(" подземного " , " ");
            });
        }
        else if (item.type == ItemID.BloodySpine)
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip0", _ =>
            {
                tooltips.ReplaceText(" подземного ", " ");
            });
        }
        else if (item.type == ModContent.ItemType<Teratoma>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Входит в ярость за пределами искажения";
            });
        }
        else if (item.type == ModContent.ItemType<BloodyWormFood>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Входит в ярость за пределами багрянца";
            });
        }
        else if (item.type == ModContent.ItemType<Seafood>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Входит в ярость за пределами вод сернистого моря";
            });
        }
        else if (item.type == ModContent.ItemType<Abombination>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Входит в ярость за пределами подземных джунглей";
            });
        }
        else if (item.type == ModContent.ItemType<NecroplasmicBeacon>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", tooltip =>
            {
                tooltip.Text = "Входит в ярость за пределами подземелья\nНе расходуется";
            });
        }
        if (item.type == ModContent.ItemType<EyeofDesolation>())
        {
            ItemHelper.TranslateTooltip(tooltips, "Tooltip1", _ =>
            {
                tooltips.ReplaceText("Забытая тень Каламитас", "Забытую тень Каламитас");
            });
        }
    }
}
