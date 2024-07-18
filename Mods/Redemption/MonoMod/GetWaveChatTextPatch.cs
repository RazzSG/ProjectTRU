// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using Redemption.Globals.World;
//
// namespace CalamityRuTranslate.Mods.Redemption.MonoMod;
//
// public class GetWaveChatTextPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null/* && TRuConfig.Instance.RedemptionLocalization*/ && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(FowlMorningNPC).GetCachedMethod(nameof(FowlMorningNPC.GetWaveChatText));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Wave: ", "Волна: ");
//     };
// }