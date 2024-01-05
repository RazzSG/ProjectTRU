// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// public class AreaNameUIPatch : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodBase ModifiedMethod => ModsCall.StarsAbove.Code.GetType("StarsAbove.UI.CelestialCartography.AreaNameUI").GetCachedMethod("DrawSelf");
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/CelestialCartography/LocationNames/", "CalamityRuTranslate/Assets/");
//     };
// }