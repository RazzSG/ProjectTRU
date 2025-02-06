// using System;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using CalamityRuTranslate.Core.MonoMod;
// using SpiritMod.UI.Elements;
// using SpiritMod.UI.QuestUI;
//
// namespace CalamityRuTranslate.Mods.Spirit.MonoMod;
//
// public class CreateButtonsPatch : OnPatcher
// {
//     public override bool AutoLoad => ModInstances.Spirit != null && TRuConfig.Instance.SpiritLocalization && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(QuestBookUI).GetCachedMethod("CreateButtons");
//
//     private delegate UIQuestBookButtonTextPanel[] CreateButtonsDelegate(QuestBookUI self, float y, float textScale, bool equalWidths, params string[] texts);
//     
//     public override Delegate Delegate => Translation;
//
//     private UIQuestBookButtonTextPanel[] Translation(CreateButtonsDelegate orig, QuestBookUI self, float y, float textScale, bool equalWidths, params string[] texts)
//     {
//         if (textScale == 0.7f)
//         {
//             textScale = 0.59f;
//         }
//         return orig.Invoke(self, y, textScale, equalWidths, texts);
//     }
// }