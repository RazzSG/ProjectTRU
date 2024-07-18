// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using Redemption.NPCs.Friendly;
//
// namespace CalamityRuTranslate.Mods.Redemption.MonoMod;
//
// public class SoullessPortalPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null && TRuConfig.Instance.RedemptionLocalization && TranslationHelper.IsRussianLanguage;
//         
//     public override MethodInfo ModifiedMethod => typeof(SoullessPortal).GetCachedMethod(nameof(SoullessPortal.SetChatButtons));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Enter Gateway", "Войти во врата");
//     };
// }