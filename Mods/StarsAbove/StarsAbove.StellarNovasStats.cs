// using System;
// using StarsAbove;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.StarsAbove;
//
// public partial class StarsAboveSystem
// {
//     private static StarsAbovePlayer StarsAbovePlayer => Main.LocalPlayer.GetModPlayer<StarsAbovePlayer>();
//
//     public void StellarNovasStats()
//     {
//         if (StarsAbovePlayer.novaUIActive)
//         {
//             string baseStatsFormat = "{0}: {1}\nБазовый расход энергии: {2}\n\n\n\n{0}: {3}\nШанс крит. удара: {4}%\n{5}: {6}\nРасход энергии: {7}";
//             string statType = StarsAbovePlayer.chosenStellarNova != 4 ? "Базовый урон" : "Базовая сила лечения";
//             string critType = StarsAbovePlayer.chosenStellarNova != 4 ? "Критический урон" : "Сила крит. лечения";
//
//             double finalDamage = Math.Round(StarsAbovePlayer.novaDamage * (1 + StarsAbovePlayer.novaDamageMod), 5);
//             int finalCritChance = StarsAbovePlayer.novaCritChance + StarsAbovePlayer.novaCritChanceMod;
//             double finalCritDamage = Math.Round(StarsAbovePlayer.novaCritDamage * (1 + StarsAbovePlayer.novaCritDamageMod), 5);
//             int energyCost = StarsAbovePlayer.novaGaugeMax - StarsAbovePlayer.novaChargeMod;
//
//             StarsAbovePlayer.baseStats = string.Format(baseStatsFormat, statType, StarsAbovePlayer.novaDamage, StarsAbovePlayer.novaGaugeMax, finalDamage, finalCritChance, critType, finalCritDamage, energyCost);
//         }
//     }
// }