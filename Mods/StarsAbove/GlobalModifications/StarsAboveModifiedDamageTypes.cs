// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using Microsoft.Xna.Framework;
// using StarsAbove.Systems;
// using Terraria;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.GlobalModifications;
//
// public class StarsAboveModifiedDamageTypes : GlobalItem
// {
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//     }
//     
//     public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
//     {
//         ItemHelper.TranslateTooltip(tooltips, "Damage", tooltip =>
//         {
//             if (item.DamageType.CountsAsClass<CelestialDamageClass>() || item.DamageType.CountsAsClass<IncarnationDamageClass>() ||
//                 item.DamageType.CountsAsClass<AuricDamageClass>() || item.DamageType.CountsAsClass<GadgetDamageClass>() ||
//                 item.DamageType.CountsAsClass<PsychomentDamageClass>())
//             {
//                 if (TRuConfig.Instance.ColoredDamageTypes)
//                     tooltip.OverrideColor = new Color(231, 255, 149);
//             }
//         });
//     }
// }