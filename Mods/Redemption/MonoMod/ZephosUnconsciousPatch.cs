// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using Redemption.NPCs.Friendly.TownNPCs;
//
// namespace CalamityRuTranslate.Mods.Redemption.MonoMod;
//
// public class ZephosUnconsciousPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null && TRuConfig.Instance.RedemptionLocalization && TranslationHelper.IsRussianLanguage;
//         
//     public override MethodInfo ModifiedMethod => typeof(ZephosUnconscious).GetCachedMethod(nameof(ZephosUnconscious.SetChatButtons));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Use Revival Potion", "Использовать зелье восстановления сил");
//     };
// }