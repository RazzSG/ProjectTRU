// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using SpiritMod.Utilities;
//
// namespace CalamityRuTranslate.Mods.Spirit.MonoMod;
//
// public class GetPluralEndingPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Spirit != null && TRuConfig.Instance.SpiritLocalization && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(QuestUtils).FindMethod(nameof(QuestUtils.GetPluralEnding));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "s", "");
//     };
// }