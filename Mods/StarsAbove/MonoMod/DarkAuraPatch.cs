// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using StarsAbove.Buffs.Magic.SupremeAuthority;
//
// namespace CalamityRuTranslate.Mods.StarsAbove.MonoMod;
//
// public class DarkAuraPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization && TranslationHelper.IsRussianLanguage;
//         
//     public override MethodInfo ModifiedMethod => typeof(DarkAura).GetCachedMethod(nameof(DarkAura.ModifyBuffText));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "BuffDescription.DarkAuraBuff", "Buffs.DarkAuraBuff.Description");
//     };
// }