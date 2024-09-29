﻿// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using Redemption.NPCs.Friendly.TownNPCs;
//
// namespace CalamityRuTranslate.Mods.Redemption.MonoMod;
//
// public class ZephosPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null/* && TRuConfig.Instance.RedemptionLocalization*/ && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(Zephos).GetCachedMethod(nameof(Zephos.ChitChat));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, " (wink wink)", " *подмигивает*");
//     };
// }