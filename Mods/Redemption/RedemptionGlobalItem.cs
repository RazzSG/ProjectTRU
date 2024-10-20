﻿// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using Redemption.Globals;
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
// using Terraria.ID;
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
//             ItemHelper.TranslateTooltip(tooltips, "Geiger1", _ =>
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
//             ItemHelper.TranslateTooltip(tooltips, "IreLine", _ =>
//             {
//                 tooltips.ReplaceText("Ukko's Ire", "Гнев Укко");
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
//                 tooltip.Text = "'Шлем-салад, выкованный из канита, который носят Небесные оруженосцы Итона\nЭтот металл имеет синеватый оттенок и холодный на ощупь, служит достойной заменой железу, столь редкому в южном Итоне\nНебесные оруженосцы - это подразделение южного Итона, под чьей защитой пребывают королевства Ильн, Кликуб и Норапасс\nИх доспехи отличаются повышенной гибкостью, что позволяет им быстро выдвигаться на помощь'";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<SkySquiresGreaves>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "HoldShift", tooltip =>
//             {
//                 tooltip.Text = "Удерживайте 'Shift', чтобы увидеть историю";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Lore", tooltip =>
//             {
//                 tooltip.Text = "'Поножи, выкованные из канита, которые носят Небесные оруженосцы Итона\nЭтот металл имеет синеватый оттенок и холодный на ощупь, служит достойной заменой железу, столь редкому в южном Итоне\nНебесные оруженосцы - это подразделение южного Итона, под чьей защитой пребывают королевства Ильн, Кликуб и Норапасс\nИх доспехи отличаются повышенной гибкостью, что позволяет им быстро выдвигаться на помощь'";
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
//                 tooltip.Text = "'Табард, сотканный из канита и ткани в клетчатом узоре, который носят Небесные оруженосцы Итона\nЭтот металл имеет синеватый оттенок и холодный на ощупь, служит достойной заменой железу, столь редкому в южном Итоне\nНебесные оруженосцы - это подразделение южного Итона, под чьей защитой пребывают королевства Ильн, Кликуб и Норапасс\nИх доспехи отличаются повышенной гибкостью, что позволяет им быстро выдвигаться на помощь'";
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
//                 tooltip.Text = "'Этот необычный меч, родом из Серебряного века, выкован из сияющей стали\nНа его поверхности почти не видно следов битв, так как его редко использовал владелец\nПрикосновение к мечу пробуждает странное чувство ностальгии'";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<SunkenCaptainPainting>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "HoldShift", tooltip =>
//             {
//                 tooltip.Text = "На обороте выгравирована надпись, удерживайте 'Shift', чтобы прочитать";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Lore", tooltip =>
//             {
//                 tooltip.Text = "'Некогда великий капитан, для некоторых ставший легендой, даже после смерти продолжал бороздить моря, ведя свою призрачную команду к неизведанным землям\nЛишь при ярчайшем свете луны могли они ступить на берег\nДо тех пор они были обречены вечно преследовать волны, а самый густой туман оставался их единственным спутником'";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<NebSummon>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "text1", tooltip =>
//             {
//                 tooltip.Text = "Нажмите ПКМ, чтобы мгновенно призвать финальную форму Небулеус";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<WeddingRing>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "SpiritLine", tooltip =>
//             {
//                 tooltip.Text = "Кольцо продолжает излучать тусклое синее...";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardHazmatZombie>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "1120 ед. базового здоровья";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "20 ед. защиты";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<MoonflareArrow>() || item.type == ModContent.ItemType<LunarShot>() | item.type == ModContent.ItemType<MoonflareStaff>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "text", tooltip =>
//             {
//                 tooltip.Text = "Отсутствует лунный свет для отражения...";
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
//                 tooltip.Text = "120/92/144 ед. базового здоровья";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "11/9/15 ед. защиты";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardCalavia>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "3000 ед. базового здоровья";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "17 ед. защиты";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardForestNymph>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "500 ед. базового здоровья";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "5 ед. защиты";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardGathicSkeletons>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "116/124 ед. базового здоровья";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "8 ед. защиты";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardGladestone>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "250 ед. базового здоровья";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "20 ед. защиты";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardMossyGoliath>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "2000 ед. базового здоровья";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "14 ед. защиты";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardSkeleton>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "108 ед. базового здоровья";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "7 ед. защиты";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardSkeletonAssassin>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "116 ед. базового здоровья";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "8 ед. защиты";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardSkullDigger>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "2400 ед. базового здоровья";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "0 ед. защиты";
//             });
//         }
//         
//         if (item.type == ModContent.ItemType<CruxCardTied>())
//         {
//             ItemHelper.TranslateTooltip(tooltips, "MaxLife", tooltip =>
//             {
//                 tooltip.Text = "418 ед. базового здоровья";
//             });
//             
//             ItemHelper.TranslateTooltip(tooltips, "Defense", tooltip =>
//             {
//                 tooltip.Text = "10 ед. защиты";
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
//
//         ItemHelper.TranslateTooltip(tooltips, "SetBonus", tooltip =>
//         {
//             Player player = Main.player[Main.myPlayer];
//             string setBonusKey = Language.GetTextValue("LegacyTooltip.48");
//             
//             if (player.armor[0].type == ItemID.CopperHelmet &&
//                 player.armor[1].type == ItemID.CopperChainmail &&
//                 player.armor[2].type == ItemID.CopperGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.ThunderS} elemental resistance", $"Увеличивает сопротивление {ElementID.ThunderS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.TinHelmet &&
//                 player.armor[1].type == ItemID.TinChainmail &&
//                 player.armor[2].type == ItemID.TinGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.ThunderS} elemental resistance", $"Увеличивает сопротивление {ElementID.ThunderS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.CactusHelmet &&
//                 player.armor[1].type == ItemID.CactusBreastplate &&
//                 player.armor[2].type == ItemID.CactusLeggings)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.NatureS} elemental resistance", $"Увеличивает сопротивление {ElementID.NatureS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.IronHelmet || player.armor[0].type == ItemID.AncientIronHelmet &&
//                 player.armor[1].type == ItemID.IronChainmail &&
//                 player.armor[2].type == ItemID.IronGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.EarthS} elemental resistance", $"Увеличивает сопротивление {ElementID.EarthS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.LeadHelmet &&
//                 player.armor[1].type == ItemID.LeadChainmail &&
//                 player.armor[2].type == ItemID.LeadGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.EarthS} elemental resistance", $"Увеличивает сопротивление {ElementID.EarthS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.SilverHelmet &&
//                 player.armor[1].type == ItemID.SilverChainmail &&
//                 player.armor[2].type == ItemID.SilverGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.ThunderS} elemental damage", $"Увеличивает урон {ElementID.ThunderS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.TungstenHelmet &&
//                 player.armor[1].type == ItemID.TungstenChainmail &&
//                 player.armor[2].type == ItemID.TungstenGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.ThunderS} elemental damage", $"Увеличивает урон {ElementID.ThunderS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.GoldHelmet || player.armor[0].type == ItemID.AncientGoldHelmet &&
//                 player.armor[1].type == ItemID.GoldChainmail &&
//                 player.armor[2].type == ItemID.GoldGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.ArcaneS} elemental resistance", $"Увеличивает сопротивление {ElementID.ArcaneS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.PlatinumHelmet &&
//                 player.armor[1].type == ItemID.PlatinumChainmail &&
//                 player.armor[2].type == ItemID.PlatinumGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.ArcaneS} elemental damage", $"Увеличивает урон {ElementID.ArcaneS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.FossilHelm &&
//                 player.armor[1].type == ItemID.FossilShirt &&
//                 player.armor[2].type == ItemID.FossilPants)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.EarthS} elemental resistance", $"Увеличивает урон {ElementID.EarthS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.JungleHat &&
//                 player.armor[1].type == ItemID.JungleShirt &&
//                 player.armor[2].type == ItemID.JunglePants)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.NatureS} elemental resistance", $"Увеличивает сопротивление {ElementID.NatureS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.ShadowHelmet &&
//                 player.armor[1].type == ItemID.ShadowScalemail &&
//                 player.armor[2].type == ItemID.ShadowGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.ShadowS} elemental resistance", $"Увеличивает сопротивление {ElementID.ShadowS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.AncientShadowHelmet &&
//                 player.armor[1].type == ItemID.AncientShadowScalemail &&
//                 player.armor[2].type == ItemID.AncientShadowGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.ShadowS} elemental resistance", $"Увеличивает сопротивление {ElementID.ShadowS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.CrimsonHelmet &&
//                 player.armor[1].type == ItemID.CrimsonScalemail &&
//                 player.armor[2].type == ItemID.CrimsonGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.BloodS} elemental resistance", $"Увеличивает сопротивление {ElementID.BloodS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.MoltenHelmet &&
//                 player.armor[1].type == ItemID.MoltenBreastplate &&
//                 player.armor[2].type == ItemID.MoltenGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.FireS} elemental resistance", $"Увеличивает сопротивление {ElementID.FireS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.CobaltHelmet || player.armor[0].type == ItemID.CobaltMask || player.armor[0].type == ItemID.CobaltHat &&
//                 player.armor[1].type == ItemID.CobaltBreastplate &&
//                 player.armor[2].type == ItemID.CobaltLeggings)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.WaterS} elemental resistance", $"Увеличивает сопротивление {ElementID.WaterS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.PalladiumHelmet || player.armor[0].type == ItemID.PalladiumHeadgear || player.armor[0].type == ItemID.PalladiumMask &&
//                 player.armor[1].type == ItemID.PalladiumBreastplate &&
//                 player.armor[2].type == ItemID.PalladiumLeggings)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.HolyS} elemental resistance", $"Увеличивает сопротивление {ElementID.HolyS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.MythrilHelmet || player.armor[0].type == ItemID.MythrilHat || player.armor[0].type == ItemID.MythrilHood &&
//                 player.armor[1].type == ItemID.MythrilChainmail &&
//                 player.armor[2].type == ItemID.MythrilGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.ArcaneS} elemental resistance", $"Увеличивает сопротивление {ElementID.ArcaneS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.OrichalcumHelmet || player.armor[0].type == ItemID.OrichalcumHeadgear || player.armor[0].type == ItemID.OrichalcumMask &&
//                 player.armor[1].type == ItemID.OrichalcumBreastplate &&
//                 player.armor[2].type == ItemID.OrichalcumLeggings)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.NatureS} elemental resistance", $"Увеличивает сопротивление {ElementID.NatureS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.AdamantiteHelmet || player.armor[0].type == ItemID.AdamantiteHeadgear || player.armor[0].type == ItemID.AdamantiteMask &&
//                 player.armor[1].type == ItemID.AdamantiteBreastplate &&
//                 player.armor[2].type == ItemID.AdamantiteLeggings)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.EarthS} elemental resistance", $"Увеличивает сопротивление {ElementID.EarthS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.TitaniumHelmet || player.armor[0].type == ItemID.TitaniumHeadgear || player.armor[0].type == ItemID.TitaniumMask &&
//                 player.armor[1].type == ItemID.TitaniumBreastplate &&
//                 player.armor[2].type == ItemID.TitaniumLeggings)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.ThunderS} elemental resistance", $"Увеличивает сопротивление {ElementID.ThunderS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.FrostHelmet &&
//                 player.armor[1].type == ItemID.FrostBreastplate &&
//                 player.armor[2].type == ItemID.FrostLeggings)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.IceS} elemental resistance", $"Увеличивает сопротивление {ElementID.IceS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.AncientBattleArmorHat &&
//                 player.armor[1].type == ItemID.AncientBattleArmorShirt &&
//                 player.armor[2].type == ItemID.AncientBattleArmorPants)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.EarthS} elemental resistance", $"Увеличивает сопротивление {ElementID.EarthS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.HallowedHeadgear || player.armor[0].type == ItemID.HallowedHelmet || player.armor[0].type == ItemID.HallowedHood || player.armor[0].type == ItemID.HallowedMask &&
//                 player.armor[1].type == ItemID.HallowedPlateMail &&
//                 player.armor[2].type == ItemID.HallowedGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.HolyS} elemental resistance", $"Увеличивает сопротивление {ElementID.HolyS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.AncientHallowedHeadgear || player.armor[0].type == ItemID.AncientHallowedHelmet || player.armor[0].type == ItemID.AncientHallowedHood || player.armor[0].type == ItemID.AncientHallowedMask &&
//                 player.armor[1].type == ItemID.AncientHallowedPlateMail &&
//                 player.armor[2].type == ItemID.AncientHallowedGreaves)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.HolyS} elemental resistance", $"Увеличивает сопротивление {ElementID.HolyS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.TurtleHelmet &&
//                 player.armor[1].type == ItemID.TurtleScaleMail &&
//                 player.armor[2].type == ItemID.TurtleLeggings)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.NatureS} elemental resistance", $"Увеличивает сопротивление {ElementID.NatureS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.TurtleHelmet &&
//                 player.armor[1].type == ItemID.TurtleScaleMail &&
//                 player.armor[2].type == ItemID.TurtleLeggings)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.NatureS} elemental resistance", $"Увеличивает сопротивление {ElementID.NatureS} на 20%");
//                 tooltips.ReplaceText($"20% increased{ElementID.EarthS} elemental resistance", $"Увеличивает сопротивление {ElementID.EarthS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.BeetleHelmet &&
//                 player.armor[1].type == ItemID.BeetleScaleMail &&
//                 player.armor[2].type == ItemID.BeetleLeggings)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.NatureS} elemental resistance", $"Увеличивает сопротивление {ElementID.NatureS} на 20%");
//                 tooltips.ReplaceText($"20% increased{ElementID.EarthS} elemental resistance", $"Увеличивает сопротивление {ElementID.EarthS} на 20%");
//             }
//             
//             if (player.armor[0].type == ItemID.SpectreHood || player.armor[0].type == ItemID.SpectreMask &&
//                 player.armor[1].type == ItemID.SpectreRobe &&
//                 player.armor[2].type == ItemID.SpectrePants)
//             {
//                 tooltips.ReplaceText($"20% increased{ElementID.ArcaneS} elemental resistance", $"Увеличивает сопротивление {ElementID.ArcaneS} на 20%");
//             }
//         });
//
//         ItemHelper.TranslateTooltip(tooltips, "SpecialPrice", tooltip =>
//         {
//             if (tooltip.Text.Contains("antique doruls"))
//             {
//                 string[] parts = tooltip.Text.Split(' ');
//                 string priceValue = parts[2];
//                 if (int.TryParse(priceValue, out int value))
//                 {
//                     string valueSuffix = LocalizedText.ApplyPluralization("{^0:античный дорул;античных дорула;античных дорулав}", value);
//                     tooltip.Text = tooltip.Text.Replace("antique doruls", valueSuffix);
//                 }
//             }
//         });
//     }
// }