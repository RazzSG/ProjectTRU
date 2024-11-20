using System.Collections.Generic;
using CalamityMod;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CatalystMod;
using CatalystMod.Items.Armor.Intergelactic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Catalyst;

public class CatalystGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage && ModInstances.Catalyst != null && ModInstances.Calamity != null && TRuConfig.Instance.CatalystLocalization;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, "SetBonus", tooltip =>
        {
            Player player = Main.player[Main.myPlayer];
            string setBonusKey = Language.GetTextValue("LegacyTooltip.48");
            string hotkey = CatalystPlayer.AsteroidVisToggleKey.TooltipHotkeyString();
            
            if (player.armor[0].type == ModContent.ItemType<IntergelacticHeadMagic>() &&
                player.armor[1].type == ModContent.ItemType<IntergelacticBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<IntergelacticGreaves>())
            {
                
                tooltip.Text = $"{setBonusKey} {Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticAll", hotkey)}\n{Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticMagic")}";
            }
            
            if (player.armor[0].type == ModContent.ItemType<IntergelacticHeadMelee>() &&
                player.armor[1].type == ModContent.ItemType<IntergelacticBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<IntergelacticGreaves>())
            {
                
                tooltip.Text = $"{setBonusKey} {Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticMelee", hotkey)}";
            }
            
            if (player.armor[0].type == ModContent.ItemType<IntergelacticHeadRanged>() &&
                player.armor[1].type == ModContent.ItemType<IntergelacticBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<IntergelacticGreaves>())
            {
                
                tooltip.Text = $"{setBonusKey} {Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticAll", hotkey)}\n{Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticRanged")}";
            }
            
            if (player.armor[0].type == ModContent.ItemType<IntergelacticHeadRogue>() &&
                player.armor[1].type == ModContent.ItemType<IntergelacticBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<IntergelacticGreaves>())
            {
                
                tooltip.Text = $"{setBonusKey} {Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticAll", hotkey)}\n{Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticRogue")}";
            }
            
            if (player.armor[0].type == ModContent.ItemType<IntergelacticHeadSummon>() &&
                player.armor[1].type == ModContent.ItemType<IntergelacticBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<IntergelacticGreaves>())
            {
                
                tooltip.Text = $"{setBonusKey} {Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticAll", hotkey)}\n{Language.GetTextValue("Mods.CatalystMod.ArmorSetBonus.IntergelacticSummon")}";
            }
        });
    }
}