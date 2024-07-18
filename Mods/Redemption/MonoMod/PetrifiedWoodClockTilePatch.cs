// using System;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using CalamityRuTranslate.Core.MonoMod;
// using Redemption.Tiles.Furniture.PetrifiedWood;
// using Terraria;
//
// namespace CalamityRuTranslate.Mods.Redemption.MonoMod;
//
// public class PetrifiedWoodClockTilePatch : OnPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null && TRuConfig.Instance.RedemptionLocalization && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(PetrifiedWoodClockTile).GetCachedMethod(nameof(PetrifiedWoodClockTile.RightClick));
//
//     private delegate bool RightClickDelegate(PetrifiedWoodClockTile self, int x, int y);
//
//     public override Delegate Delegate => Translation;
//     
//     private bool Translation(RightClickDelegate orig, PetrifiedWoodClockTile self, int x, int y)
//     {
//         double time = Main.time;
//         
//         if (!Main.dayTime)
//             time += 54000.0;
//         
//         time = time / 86400.0 * 24.0;
//         time = (time - 7.5 - 12.0 + 24.0) % 24.0;
//
//         int intTime = (int)time;
//         double minutes = (int)((time - intTime) * 60.0);
//         string text = minutes.ToString("00");
//         
//         Main.NewText($"Время: {intTime}:{text}", 255, 240, 20);
//         return true;
//     }
// }