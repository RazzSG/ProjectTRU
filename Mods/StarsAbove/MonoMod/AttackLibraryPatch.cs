// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using Mono.Cecil.Cil;
// using MonoMod.Cil;
// using StarsAbove;
// using StarsAbove.NPCs.Nalhaun;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// public class AttackLibraryPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodBase ModifiedMethod => typeof(NalhaunBoss).GetCachedMethod("SpawnAnimation");
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         var cursor = new ILCursor(il);
//         cursor.TryGotoNext(i => i.MatchLdsflda(typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Nalhaun_NalhaunIntroQuote))));
//         cursor.Remove();
//         cursor.Emit(OpCodes.Ldsflda, typeof(CalamityRuTranslate).GetField(nameof(CalamityRuTranslate.Nalhaun_AndNowTheScalesWillTip)));
//     };
// }