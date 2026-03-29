using System.Collections.Generic;
using CalamityMod;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public partial class CalamityModGlobalItem
{
    public void ModifyDamageTypes(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, "Damage", tooltip =>
        {
            if (item.CountsAsClass<RogueDamageClass>())
            {
                if (TRuConfig.Instance.ColoredDamageTypes)
                    tooltip.OverrideColor = new Color(255, 184, 108);
            }

            if (item.CountsAsClass<TrueMeleeDamageClass>() || item.CountsAsClass<TrueMeleeNoSpeedDamageClass>())
            {
                if (TRuConfig.Instance.ColoredDamageTypes)
                    tooltip.OverrideColor = new Color(255, 85, 85);
            }
            
            if (item.CountsAsClass<MeleeRangedHybridDamageClass>())
            {
                if (TRuConfig.Instance.ColoredDamageTypes)
                {
                    string[] parts = tooltip.Text.Split('/');
                    if (parts.Length == 2)
                    {
                        string meleeColor = "FF5555";
                        string rangedColor = "50FA7B";
                        
                        tooltip.Text = $"[c/{meleeColor}:{parts[0]}]/[c/{rangedColor}:{parts[1]}]";
                    }
                }
            }
        });
    }
}