// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using SpiritMod.Mechanics.SpecialSellItem;
// using Terraria;
// using Terraria.Localization;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Spirit;
//
// public class SpiritModGlobalItem : GlobalItem
// {
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModInstances.Spirit != null && TRuConfig.Instance.SpiritLocalization && TranslationHelper.IsRussianLanguage;
//     }
//
//     public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
//     {
//         if (item.ModItem is ISpecialSellItem specialSellItem)
//         {
//             ItemHelper.TranslateTooltip(tooltips, "Price", _ =>
//             {
//                 string valueSuffix = LocalizedText.ApplyPluralization("{^0:глиф;глифа;глифов}", specialSellItem.SellAmount());
//                 tooltips.ReplaceText("glyphs", valueSuffix);
//             });
//         }
//     }
// }