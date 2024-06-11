// using CalamityRuTranslate.Common.Utilities;
// using Terraria.GameContent.UI.Elements;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;
//
// public class InternalSetTextPatch : ILoadable
// {
//     public bool IsLoadingEnabled(Mod mod)
//     {
//         return TranslationHelper.IsRussianLanguage;
//     }
//
//     public void Load(Mod mod)
//     {
//         On_UIText.InternalSetText += On_UITextOnInternalSetText;
//     }
//     
//     public void Unload()
//     {
//         On_UIText.InternalSetText -= On_UITextOnInternalSetText;
//     }
//     
//     private void On_UITextOnInternalSetText(On_UIText.orig_InternalSetText orig, UIText self, object text, float textscale, bool large)
//     {
//         if (text.ToString()!.Contains("Базовый урон: ") || text.ToString()!.Contains("Базовая сила лечения: ") ||
//             text.ToString()!.Contains("Урон: ") || text.ToString()!.Contains("Сила лечения: "))
//         {
//             if (textscale == 0.8f)
//                 textscale = 0.63f;
//         }
//
//         orig.Invoke(self, text, textscale, large);
//     }
// }