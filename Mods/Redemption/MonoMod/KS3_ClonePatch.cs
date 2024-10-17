// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using Redemption.NPCs.Bosses.KSIII;
//
// namespace CalamityRuTranslate.Mods.Redemption.MonoMod;
//
// public class KS3_ClonePatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null/* && TRuConfig.Instance.RedemptionLocalization*/ && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(KS3_Clone).GetCachedMethod(nameof(KS3_Clone.BossLoot));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "A King Slayer III Clone", "Клон Короля-охотника III");
//     };
// }