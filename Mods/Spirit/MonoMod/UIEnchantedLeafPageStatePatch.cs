// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.Spirit.MonoMod;
//
// public class UIEnchantedLeafPageStatePatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.Spirit != null && TRuConfig.Instance.SpiritLocalization && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => ModInstances.Spirit.Code.GetType("SpiritMod.Items.Books.UI.MaterialUI.UIEnchantedLeafPageState").GetCachedMethod("get_BackgroundTexturePath");
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "SpiritMod/Items/Books/UI/MaterialUI/EnchantedLeafMaterialPage", "CalamityRuTranslate/Assets/Sprites/Spirit/Books/UI/MaterialUI/EnchantedLeafMaterialPage");
//     };
// }