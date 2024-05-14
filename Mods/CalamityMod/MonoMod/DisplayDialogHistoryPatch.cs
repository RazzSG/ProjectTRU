// using System.Reflection;
// using CalamityMod.UI.DraedonSummoning;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;
//
// public class DisplayDialogHistoryPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
//         
//     public override MethodInfo ModifiedMethod => typeof(CodebreakerUI).GetCachedMethod(nameof(CodebreakerUI.DisplayDialogHistory));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         // Ширина текста диалогов Дрэйдона
//         TranslationHelper.ModifyIL(il, 336, 436);
//     };
// }