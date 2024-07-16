// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using Redemption.BaseExtension;
// using Redemption.Globals.Player;
// using Redemption.Items.Accessories.HM;
// using Terraria;
// using Terraria.Localization;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Redemption;
//
// public class RedemptionGlobalItem : GlobalItem
// {
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return TranslationHelper.IsRussianLanguage && ModInstances.Redemption != null;
//     }
//
//     public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
//     {
//         if (item.type == ModContent.ItemType<GeigerMuller>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "Geiger1", tooltip =>
//             {
//                 tooltips.ReplaceText("No doses of radiation detected on self, nothing to note.", "Никакой дозы радиации не обнаружено. Всё в норме");
//                 tooltips.ReplaceText("Low doses of radiation detected on self, nothing to note.", "Обнаружена низкая доза радиации. Всё в норме");
//                 tooltips.ReplaceText("Medium doses of radiation detected on self, have TeoChrome-issued pills on hand just in case.", "Обнаружена средняя доза радиации. Держите при себе таблетки, разработанные ТеоХром, на всякий случай");
//                 tooltips.ReplaceText("High doses of radiation detected on self, have TeoChrome-issued pills on hand just in case.", "Обнаружена высокая доза радиации. Держите при себе таблетки, разработанные ТеоХром, на всякий случай");
//                 tooltips.ReplaceText("Very high doses of radiation detected on self, high chance of irradiation and suffering ARS.", "Обнаружена очень высокая доза радиации. Высокий шанс облучения и развития ОЛБ");
//                 tooltips.ReplaceText("Extreme doses of radiation detected on self, Acute Radiation Syndrome detected.", "Обнаружена экстремальная доза радиации. Получена острая лучевая болезнь");
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Geiger2", tooltip =>
//             {
//                 tooltip.Text = $"Уровень облучения {tooltip.Text.Split(' ')[0]}";
//             });
//         }
//     }
// }