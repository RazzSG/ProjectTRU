// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// public class CelestialCompassDrawSelf : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodBase ModifiedMethod => ModsCall.StarsAbove.Code.GetType("StarsAbove.UI.CelestialCartography.CelestialCompass").GetCachedMethod("DrawSelf");
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/CelestialCartography/LocationDescriptionTextBox", "CalamityRuTranslate/Assets/LocationDescriptionTextBox");
//     };
// }
//
// public class CelestialCompassUpdate : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodBase ModifiedMethod => ModsCall.StarsAbove.Code.GetType("StarsAbove.UI.CelestialCartography.CelestialCompass").GetCachedMethod("Update");
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         // Сдвигаем текст по Y вниз из-за нового размера спрайта
//         TranslationHelper.ModifyIL(il, 524f, 539f);
//         TranslationHelper.ModifyIL(il, 546f, 561f);
//         TranslationHelper.ModifyIL(il, 568f, 583f);
//     };
// }