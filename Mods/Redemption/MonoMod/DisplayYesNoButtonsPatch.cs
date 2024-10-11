// using System;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using CalamityRuTranslate.Core.MonoMod;
// using Microsoft.Xna.Framework;
// using Redemption.UI;
//
// namespace CalamityRuTranslate.Mods.Redemption.MonoMod;
//
// public class DisplayYesNoButtonsPatch : OnPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null /*&& TRuConfig.Instance.RedemptionLocalization*/ && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(YesNoUI).GetCachedMethod(nameof(YesNoUI.DisplayYesNoButtons));
//
//     private delegate void DisplayYesNoButtonsDelegate(YesNoUI self, string yesText, string noText, Vector2? textOffset, Vector2? textOffset2, float textScale, float textScale2);
//
//     public override Delegate Delegate => Translation;
//     
//     private void Translation(DisplayYesNoButtonsDelegate orig, YesNoUI self, string yesText, string noText, Vector2? textOffset, Vector2? textOffset2, float textScale, float textScale2)
//     {
//         textScale = textScale is 0.6f or 0.75f ? 0.4f : textScale;
//         textScale2 = textScale2 is 0.6f or 0.75f ? 0.4f : textScale2;
//
//         if (textOffset.HasValue)
//         {
//             textOffset = textOffset.Value.Y switch
//             {
//                 28f => textOffset.Value with { Y = 23f },
//                 15f => textOffset.Value with { Y = 45f },
//                 _ => textOffset
//             };
//         }
//
//         if (textOffset2.HasValue)
//         {
//             textOffset2 = textOffset2.Value.Y switch
//             {
//                 28f => textOffset2.Value with { Y = 45f },
//                 15f => textOffset2.Value with { Y = 45f },
//                 _ => textOffset2
//             };
//         }
//
//         orig.Invoke(self, yesText, noText, textOffset, textOffset2, textScale, textScale2);
//     }
// }