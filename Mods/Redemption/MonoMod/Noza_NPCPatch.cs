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
// public class Noza_NPCPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null && TRuConfig.Instance.RedemptionLocalization && TranslationHelper.IsRussianLanguage;
//         
//     public override MethodInfo ModifiedMethod => typeof(Noza_NPC).GetCachedMethod(nameof(Noza_NPC.SetChatButtons));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Who are you?", "Кто ты?");
//     };
// }