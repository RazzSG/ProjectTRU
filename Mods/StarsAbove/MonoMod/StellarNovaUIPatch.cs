// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
//
// namespace CalamityRuTranslate.Mods.StarsAbove.MonoMod;
//
// public class StellarNovaUIPatch : ILPatcher
// {
//     public override bool AutoLoad => ModInstances.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => ModInstances.StarsAbove.Code.GetType("StarsAbove.UI.StellarNova.StellarNovaUI").GetCachedMethod("DrawSelf");
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/prototokiaIcon", "CalamityRuTranslate/Assets/Sprites/StarsAbove/prototokiaIcon");
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/laevateinnIcon", "CalamityRuTranslate/Assets/laevateinnIcon");
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/KiwamiRyukenIcon", "CalamityRuTranslate/Assets/KiwamiRyukenIcon");
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/gardenofavalonIcon", "CalamityRuTranslate/Assets/gardenofavalonIcon");
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/edingenesisquasarIcon", "CalamityRuTranslate/Assets/edingenesisquasarIcon");
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/unlimitedbladeworksIcon", "CalamityRuTranslate/Assets/unlimitedbladeworksIcon");
//         TranslationHelper.ModifyIL(il, "StarsAbove/UI/StellarNova/guardianslightIcon", "CalamityRuTranslate/Assets/guardianslightIcon");
//     };
// }