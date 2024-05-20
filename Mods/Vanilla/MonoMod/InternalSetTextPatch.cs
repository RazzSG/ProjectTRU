// using System.Collections.Generic;
// using CalamityRuTranslate.Common.Utilities;
// using Terraria.GameContent.UI.Elements;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;
//
// public class InternalSetTextPatch : ILoadable
// {
//     private IEnumerable<string> _novaDialogues = new []
//     {
//         "Игры кончились!",
//         "Время расплаты!",
//         "Не останавливаемся!",
//         "(Смеётся), отлично!",
//         "Ни за что не отступлю!",
//         "Пора изменить правила игры!",
//         "Я покажу вам свою ИСТИННУЮ силу!",
//         "Вы сами подписали себе приговор, встав против нас.",
//         "Смиритесь со своей судьбой.",
//         "Зачем тянуть, если можно решить проблему здесь и сейчас?",
//         "Не стоит недооценивать меня!",
//         "Покончим с этим.",
//         "Даже не думайте о бегстве!",
//         "Как пожелаешь.",
//         "В звёздную пыль сотру!",
//         "Вот он, мой звёздный час!",
//         "Я НЕ отступлюсь ни на шаг.",
//         "Сейчас или никогда.",
//         "Погоди, а какую мы сейчас используем?",
//         "Цель захвачена.",
//         "Я покажу вам свою истинную силу.",
//         "Вау. Неужели это всё, на что вы способны?",
//         "Смиритесь со своей судьбой. Иного выбора вам не дано.",
//         "О поражении нет и речи.",
//         "Покоритесь энтропии!",
//         "Пора покончить с этим.",
//         "Не ожидали такого поворота, а?",
//         "Пришло время показать себя.",
//         "(Смеётся)",
//         "Время расплаты.",
//         "Это наш шанс; не упустим его.",
//         "Эм-м, как же там было? Что-то там...",
//     };
//     
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
//         if (text.ToString()!.Contains("Базовый урон: ") || text.ToString()!.Contains("Базовая сила лечения: "))
//         {
//             if (textscale == 0.8f)
//                 textscale = 0.63f;
//         }
//
//         foreach (string dialogue in _novaDialogues)
//         {
//             if (text.ToString() == dialogue)
//             {
//                 if (textscale == 2f)
//                     textscale = 1.8f;
//             }
//         }
//
//         orig.Invoke(self, text, textscale, large);
//     }
// }