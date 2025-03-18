using System.Collections.Generic;
using CalamityMod.Items.Armor.Demonshade;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.NoxusBoss;

public class NoxusBossGlobalItem : GlobalItem
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, "SetBonus", tooltip =>
        {
            Player player = Main.player[Main.myPlayer];

            if (player.armor[0].type == ModContent.ItemType<DemonshadeHelm>() &&
                player.armor[1].type == ModContent.ItemType<DemonshadeBreastplate>() &&
                player.armor[2].type == ModContent.ItemType<DemonshadeGreaves>())
            {
                tooltip.Text = tooltip.Text.Replace("125", "50").Replace("25", "50");
            }
        });
    }
}