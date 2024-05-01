// using System;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using CalamityRuTranslate.Core.MonoMod;
//
// namespace CalamityRuTranslate.Mods.StarsAbove.MonoMod;
//
// public class WrapPatch : OnPatcher
// {
//     public override bool AutoLoad => ModInstances.StarsAbove != null && TRuConfig.Instance.NewRussianTerrariaFont && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => ModInstances.StarsAbove.Code.GetType("StarsAbove.Utilities.LangHelper").GetCachedMethod("Wrap");
//
//     private delegate string WrapDelegate(ReadOnlySpan<char> text, int limit);
//     
//     public override Delegate Delegate => Translation;
//
//     private string Translation(WrapDelegate orig, ReadOnlySpan<char> text, int limit)
//     {
//         limit = (int)(limit / 1.16f);
//
//         // Stellar Array
//         if (limit == 60)
//             limit = 70;
//         
//         // // Stellar Nova
//         // if (limit == 71)
//         //     limit = 73;
//         
//         return orig.Invoke(text, limit);
//     }
// }