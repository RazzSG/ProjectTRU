// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using StarsAbove;
// using StarsAbove.NPCs;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// public class PenthesileaPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(Penthesilea).GetCachedMethod(nameof(Penthesilea.AI));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_AlrightMyTurn)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_AlrightMyTurn)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_CutThrough)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_CutThrough)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_Enough)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_Enough)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_HowFoolish)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_HowFoolish)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_HowFun)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_HowFun)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_ISenseTheirResolve)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_ISenseTheirResolve)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_IveEnduredFarWorse)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_IveEnduredFarWorse)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_OutOfMyWay)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_OutOfMyWay)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_PenthLaugh)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_PenthLaugh)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_QuickQuick)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_QuickQuick)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_ThisllCheerMeUp)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_ThisllCheerMeUp)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_ToPieces)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_ToPieces)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_ToShreds)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_ToShreds)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_TryAgainIDareYou)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_TryAgainIDareYou)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_WithHaste)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_WithHaste)));
//         TranslationHelper.ModifyIL(il, typeof(StarsAboveAudio).GetField(nameof(StarsAboveAudio.Penthesilea_WhateverItTakes)), typeof(StarsAboveSounds).GetField(nameof(StarsAboveSounds.Penthesilea_WhateverItTakes)));
//     };
// }