using System.Collections.Generic;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Microsoft.Xna.Framework;
using StarsAbove.Systems;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.StarsAbove;

public partial class StarsAboveGlobalItem
{
    public void ModifyDamageTypes(Item item, List<TooltipLine> tooltips)
    {
        ItemHelper.TranslateTooltip(tooltips, "Damage", tooltip =>
        {
            if (item.DamageType.CountsAsClass<CelestialDamageClass>() || item.DamageType.CountsAsClass<IncarnationDamageClass>() ||
                item.DamageType.CountsAsClass<AuricDamageClass>() || item.DamageType.CountsAsClass<GadgetDamageClass>() ||
                item.DamageType.CountsAsClass<PsychomentDamageClass>() || item.DamageType.CountsAsClass<ChionicDamageClass>())
            {
                if (TRuConfig.Instance.ColoredDamageTypes)
                    tooltip.OverrideColor = new Color(231, 255, 149);
            }
        });
    }
}