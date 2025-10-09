// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using SpiritMod.Items.Consumable;
// using SpiritMod.Items.Consumable.Potion;
// using SpiritMod.Items.Sets.OlympiumSet.ArtemisHunt;
// using SpiritMod.Items.Sets.OlympiumSet.BetrayersChains;
// using SpiritMod.Items.Sets.OlympiumSet.Eleutherios;
// using SpiritMod.Items.Sets.OlympiumSet.MarkOfZeus;
// using SpiritMod.Mechanics.SpecialSellItem;
// using SpiritMod.NPCs.Town.Oracle;
// using Terraria;
// using Terraria.ID;
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
//
//         if (item.type == ModContent.ItemType<ArtemisHunt>() || item.type == ModContent.ItemType<MarkOfZeus>() ||
//             item.type == ModContent.ItemType<BetrayersChains>() || item.type == ModContent.ItemType<Eleutherios>() ||
//             item.type == ModContent.ItemType<MirrorCoat>() || item.type == ModContent.ItemType<OliveBranch>() ||
//             item.type == ModContent.ItemType<OracleScripture>() || item.type == ItemID.PocketMirror)
//         {
//             ItemHelper.TranslateTooltip(tooltips, "SpecialPrice", _ =>
//             {
//                 string[] parts = tooltip.Text.Split(' ');
//                 string price = parts[2];
//                 if (int.TryParse(price, out int value))
//                 {
//                     string valueSuffix = LocalizedText.ApplyPluralization("{^0:Олимпиевый жетон;Олимпиевых жетона;Олимпиевых жетонов}", value);
//                     tooltips.ReplaceText("Олимпиевый жетонs", valueSuffix);
//                 }
//             });
//         }
//     }
// }