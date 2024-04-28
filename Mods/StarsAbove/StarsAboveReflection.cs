// using System;
// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using StarsAbove;
// using Terraria;
// using Terraria.ModLoader;
// using Terraria.UI;
//
// namespace CalamityRuTranslate.Mods.StarsAbove;
//
// public class StarsAboveReflection : ModSystem
// {
//     private static StarsAbovePlayer StarsAbovePlayer => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>();
//
//     public override bool IsLoadingEnabled(Mod mod) => ModInstances.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
//     {
//         if (StarsAbovePlayer.chosenStellarNova != 4)
//         {
//             StarsAbovePlayer.baseStats = $"Базовый урон: {StarsAbovePlayer.novaDamage}\nБазовый расход\nэнергии: {StarsAbovePlayer.novaGaugeMax}\n\nУрон: {Math.Round(StarsAbovePlayer.novaDamage * (1 + StarsAbovePlayer.novaDamageMod), 5)}\nШанс крит. удара: {StarsAbovePlayer.novaCritChance + StarsAbovePlayer.novaCritChanceMod}%\nКрит. урон: {Math.Round(StarsAbovePlayer.novaCritDamage * (1 + StarsAbovePlayer.novaCritDamageMod), 5)}\nРасход энергии: {StarsAbovePlayer.novaGaugeMax - StarsAbovePlayer.novaChargeMod}";
//         }
//         else
//         {
//             StarsAbovePlayer.baseStats = $"Базовая сила\nлечения: {StarsAbovePlayer.novaDamage}\nБазовый расход\nэнергии: {StarsAbovePlayer.novaGaugeMax}\n\nСила лечения: {Math.Round(StarsAbovePlayer.novaDamage * (1 + StarsAbovePlayer.novaDamageMod), 5)}\nШанс крит. удара: {StarsAbovePlayer.novaCritChance + StarsAbovePlayer.novaCritChanceMod}%\nСила крит. лечения: {Math.Round(StarsAbovePlayer.novaCritDamage * (1 + StarsAbovePlayer.novaCritDamageMod), 5)}\nРасход энрегии: {StarsAbovePlayer.novaGaugeMax - StarsAbovePlayer.novaChargeMod}";
//         }
//     }
// }