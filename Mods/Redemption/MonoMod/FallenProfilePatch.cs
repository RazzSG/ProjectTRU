// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using Redemption.NPCs.Friendly.TownNPCs;
//
// namespace CalamityRuTranslate.Mods.Redemption.MonoMod;
//
// public class GetTextureNPCShouldUsePatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null/* && TRuConfig.Instance.RedemptionLocalization*/ && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(FallenProfile).GetCachedMethod(nameof(FallenProfile.GetTextureNPCShouldUse));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Tenvon", "Тенвон");
//         TranslationHelper.ModifyIL(il, "Happins", "Хэппинс");
//     };
// }
//
// public class GetHeadTextureIndexPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null/* && TRuConfig.Instance.RedemptionLocalization*/ && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(FallenProfile).GetCachedMethod(nameof(FallenProfile.GetHeadTextureIndex));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Tenvon", "Тенвон");
//         TranslationHelper.ModifyIL(il, "Happins", "Хэппинс");
//     };
// }