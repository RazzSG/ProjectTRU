// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using Redemption.BaseExtension;
// using Redemption.Globals.Player;
// using Redemption.Items.Accessories.HM;
// using Redemption.Items.Accessories.PostML;
// using Redemption.Items.Armor.Vanity.SkySquire;
// using Redemption.Items.Placeable.Furniture.Misc;
// using Redemption.Items.Usable.Summons;
// using Redemption.Items.Weapons.HM.Summon;
// using Redemption.Items.Weapons.PreHM.Ammo;
// using Redemption.Items.Weapons.PreHM.Melee;
// using Redemption.Items.Weapons.PreHM.Ranged;
// using Redemption.Items.Weapons.PreHM.Summon;
// using Redemption.Rarities;
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
//         return TranslationHelper.IsRussianLanguage && /*TRuConfig.Instance.RedemptionLocalization &&*/ ModInstances.Redemption != null;
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
//
//         if (item.type == ModContent.ItemType<VasaraPendant>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "IreLine", tooltip =>
//             {
//                 tooltips.ReplaceText("Ukko's Ire", "");
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<SkySquiresHelm>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "HoldShift", tooltip =>
//             {
//                 tooltip.Text = "Удерживайте 'Shift', чтобы увидеть историю";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Lore", tooltip =>
//             {
//                 tooltip.Text = "'A sallet helm made of Kanite, worn by the Sky Squires of Ithon. The metal has a blue hue and a cold touch,\nbeing used as a replacement for iron which is lacking in southern Ithon.\n\nThe Sky Squires are a unit of southern Ithon, protecting the kingdoms of Yln, Klycub, and Norapass.\nThe armour they wear allows better flexibility than most, useful for marching to the rescue swiftly.'";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<SkySquiresHelm>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "HoldShift", tooltip =>
//             {
//                 tooltip.Text = "Удерживайте 'Shift', чтобы увидеть историю";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Lore", tooltip =>
//             {
//                 tooltip.Text = "'A sallet helm made of Kanite, worn by the Sky Squires of Ithon. The metal has a blue hue and a cold touch,\nbeing used as a replacement for iron which is lacking in southern Ithon.\n\nThe Sky Squires are a unit of southern Ithon, protecting the kingdoms of Yln, Klycub, and Norapass.\nThe armour they wear allows better flexibility than most, useful for marching to the rescue swiftly.'";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<SkySquiresTabard>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "HoldShift", tooltip =>
//             {
//                 tooltip.Text = "Удерживайте 'Shift', чтобы увидеть историю";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Lore", tooltip =>
//             {
//                 tooltip.Text = "'A tabard made of Kanite and cloth in a checkered pattern, worn by the Sky Squires of Ithon. The metal\nhas a blue hue and a cold touch, being used as a replacement for iron which is lacking in southern Ithon.\n\nThe Sky Squires are a unit of southern Ithon, protecting the kingdoms of Yln, Klycub, and Norapass.\nThe armour they wear allows better flexibility than most, useful for marching to the rescue swiftly.'";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<DoppelsSword>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "HoldShift", tooltip =>
//             {
//                 tooltip.Text = "Удерживайте 'Shift', чтобы увидеть историю";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Lore", tooltip =>
//             {
//                 tooltip.Text = "'A strange sword from the Silver Age, made of shining steel. Marks of battle are scarce,\nas it was seldom used by its wielder. It feels oddly nostalgic.'";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<SunkenCaptainPainting>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "HoldShift", tooltip =>
//             {
//                 tooltip.Text = "On the backside there's a note, hold [Shift] to read";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Lore", tooltip =>
//             {
//                 tooltip.Text = "'Once a great captain, a legend to some,\nEven after death would he still sail the seas,\nLeading his phantom crew to unknown lands.\nOnly under the brightest light of the moon\nCould they set a foot on a seashore.\nUntil then, they were ever chasing waves\nWith the thickest of fog keeping them company.'";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<NebSummon>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "text1", tooltip =>
//             {
//                 tooltip.Text = "Right-click to summon Nebuleus' Final Form instantly";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<WeddingRing>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "SpiritLine", tooltip =>
//             {
//                 tooltip.Text = "The ring still glows a faint blue...";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardHazmatZombie>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "1120 base health";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "20 defense";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<MoonflareArrow>() || item.type == ModContent.ItemType<LunarShot>() | item.type == ModContent.ItemType<MoonflareStaff>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "text", tooltip =>
//             {
//                 tooltip.Text = "There is no moonlight to reflect...";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<ForestNymphsSickle>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "Damage", _ =>
//             {
//                 tooltips.ReplaceText("melee урона", "ед. урона ближнего боя");
//                 tooltips.ReplaceText("magic урона", "ед. магического урона");
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardAnglonSkeletons>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "120/92/144 base health";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "11/9/15 defense";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardCalavia>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "3000 base health";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "17 defense";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardForestNymph>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "500 base health";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "5 defense";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardGathicSkeletons>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "116/124 base health";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "8 defense";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardGladestone>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "250 base health";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "20 defense";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardMossyGoliath>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "2000 base health";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "14 defense";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardSkeleton>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "108 base health";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "7 defense";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardSkeletonAssassin>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "116 base health";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "8 defense";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardSkullDigger>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "2400 base health";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "0 defense";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardTied>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "418 base health";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "10 defense";
//             });
//         }
//         
//         if (item.rare == ModContent.RarityType<DonatorRarity>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "DonatorLine", tooltip =>
//             {
//                 tooltip.Text = "-Предмет патрона-";
//             });
//         }
//     }
// }