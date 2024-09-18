// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using Redemption;
//
// namespace CalamityRuTranslate.Mods.Redemption.MonoMod;
//
// public class DrawOmegaTransmitterTextPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null /*&& TRuConfig.Instance.RedemptionLocalization*/ && TranslationHelper.IsRussianLanguage;
//         
//     public override MethodInfo ModifiedMethod => typeof(RedeSystem).GetCachedMethod(nameof(RedeSystem.DrawOmegaTransmitterText));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Right-click to switch Prototype", "");
//     };
// }
//
// public class DrawChoiceTextPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null /*&& TRuConfig.Instance.RedemptionLocalization*/ && TranslationHelper.IsRussianLanguage;
//         
//     public override MethodInfo ModifiedMethod => typeof(RedeSystem).GetCachedMethod(nameof(RedeSystem.DrawChoiceText));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Open Inventory to make your choice", "Откройте инвентарь, чтобы сделать свой выбор");
//     };
// }
//
// public class DrawSkeletonInvasionUIPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null /*&& TRuConfig.Instance.RedemptionLocalization*/ && TranslationHelper.IsRussianLanguage;
//         
//     public override MethodInfo ModifiedMethod => typeof(RedeSystem).GetCachedMethod(nameof(RedeSystem.DrawSkeletonInvasionUI));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Until Party's Over: ", "До конца вечеринки: ");
//         TranslationHelper.ModifyIL(il, "Raveyard", "Тусовище");
//     };
// }
//
// public class DrawFowlMorningUIPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null /*&& TRuConfig.Instance.RedemptionLocalization*/ && TranslationHelper.IsRussianLanguage;
//         
//     public override MethodInfo ModifiedMethod => typeof(RedeSystem).GetCachedMethod(nameof(RedeSystem.DrawFowlMorningUI));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Wave ", "Волна ");
//         TranslationHelper.ModifyIL(il, "Fowl Morning", "Кудах-заря");
//     };
// }