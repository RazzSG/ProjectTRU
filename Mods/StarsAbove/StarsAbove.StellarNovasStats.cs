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
//             if (StarsAbovePlayer.chosenStellarNova != 4)
//             {
//                 StarsAbovePlayer.baseStats = $"Базовый урон: {StarsAbovePlayer.novaDamage}\nБазовый расход\nэнергии: {StarsAbovePlayer.novaGaugeMax}\n\nУрон: {Math.Round(StarsAbovePlayer.novaDamage * (1 + StarsAbovePlayer.novaDamageMod), 5)}\nШанс крит. удара: {StarsAbovePlayer.novaCritChance + StarsAbovePlayer.novaCritChanceMod}%\nКрит. урон: {Math.Round(StarsAbovePlayer.novaCritDamage * (1 + StarsAbovePlayer.novaCritDamageMod), 5)}\nРасход энергии: {StarsAbovePlayer.novaGaugeMax - StarsAbovePlayer.novaChargeMod}";
//             }
//             else
//             {
//                 StarsAbovePlayer.baseStats = $"Базовая сила леч.: {StarsAbovePlayer.novaDamage}\nБазовый расход\nэнергии: {StarsAbovePlayer.novaGaugeMax}\n\nСила лечения: {Math.Round(StarsAbovePlayer.novaDamage * (1 + StarsAbovePlayer.novaDamageMod), 5)}\nШанс крит. удара: {StarsAbovePlayer.novaCritChance + StarsAbovePlayer.novaCritChanceMod}%\nСила крит. леч.: {Math.Round(StarsAbovePlayer.novaCritDamage * (1 + StarsAbovePlayer.novaCritDamageMod), 5)}\nРасход энергии: {StarsAbovePlayer.novaGaugeMax - StarsAbovePlayer.novaChargeMod}";
//             }
//         }
//     }
// }