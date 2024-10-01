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
// public class DisplayDialoguePatch : OnPatcher
// {
//     private delegate void DisplayDialogueDelegate(MoRDialogueUI self, string text, int displayTime, int fadeTime, float fontScale, string whosespeaking, float shakestrength, Color? textColor, Color? shadowColor, Vector2? textPosition, Vector2? speakerPosition, int font, int id, bool sound);
//     
//     public override bool AutoLoad => ModInstances.Redemption != null && TRuConfig.Instance.RedemptionLocalization && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(MoRDialogueUI).GetCachedMethod(nameof(MoRDialogueUI.DisplayDialogue));
//
//     public override Delegate Delegate => Translation;
//
//     private void Translation(DisplayDialogueDelegate orig, MoRDialogueUI self, string text, int displayTime, int fadeTime, float fontScale, string whosespeaking, float shakestrength, Color? textColor, Color? shadowColor, Vector2? textPosition, Vector2? speakerPosition, int font, int id, bool sound)
//     {
//         text = text switch
//         {
//             "A storm is brewing..." => "Надвигается буря...",
//             "... And nature trembles" => "... И природа трепещет",
//             "The Gods' wrath is upon you" => "Боги обрушили на вас свой гнев",
//             "Octavia..." => "Октавия...",
//             _ => text
//         };
//         
//         orig.Invoke(self, text, displayTime, fadeTime, fontScale, whosespeaking, shakestrength, textColor, shadowColor, textPosition, speakerPosition, font, id, sound);
//     }
// }