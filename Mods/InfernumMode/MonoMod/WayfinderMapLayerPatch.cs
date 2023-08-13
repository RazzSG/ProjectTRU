﻿// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using InfernumMode.Common;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;
//
// public class WayfinderMapLayerPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(WayfinderMapLayer).GetCachedMethod(nameof(WayfinderMapLayer.Draw));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Wayfinder Gate", "Путеводные врата");
//     };
// }