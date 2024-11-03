// using System.Collections.Generic;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using Microsoft.Xna.Framework;
// using Redemption.DamageClasses;
// using Terraria;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Redemption;
//
// public partial class RedemptionGlobalItem
// {
//     public void ModifyDamageTypes(Item item, List<TooltipLine> tooltips)
//     {
//         ItemHelper.TranslateTooltip(tooltips, "Damage", tooltip =>
//         {
//             if (item.CountsAsClass<RitualistClass>())
//             {
//                 if (TRuConfig.Instance.ColoredDamageTypes)
//                     tooltip.OverrideColor = new Color(251, 170, 7);
//             }
//         });
//     }
// }