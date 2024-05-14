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
//         "Я ни за что не отступлю!",
//         "О побеге и думать не смей.",
//         "Одним ударом!",
//         "Твоё желание для меня закон.",
//         "Ваши попытки тщетны! Даже я не могу остановить неизбежное.",
//         "Не о чем мне сожалеть; это мой единственный путь",
//         "Вот он, мой звёздный час!",
//         "Я не остановлюсь на этом.",
//         "Я сотру вас в звёздную пыль!",
//         "Покончим с этим.",
//         "Не стоит недооценивать меня!",
//         "Зачем тянуть, если можно решить проблему здесь и сейчас?",
//         "Ваша судьба в моих руках.",
//         "Вы сами подписали себе приговор, восстав против нас.",
//         "Я покажу тебе свою ИСТИННУЮ силу!",
//         "Погоди, а какую из них мы уже использовали?",
//         "Пришло время показать себя.",
//         "О побеге и думать не смей.",
//         "Не ожидали такого поворота, а?",
//         "Я покажу тебе обитель души.",
//         "Знайте, вы ничтожны передо мной.",
//         "Тело моё клинки...",
//         "Пора покончить с этим.",
//         "Прочь с глаз моих.",
//         "Покоритесь энтропии.",
//         "Я не остановлюсь на достигнутом.",
//         "Да будут звёзды вашей погибелью.",
//         "О поражении не было и речи.",
//         "Ваша судьба в моих руках. Сдавайтесь.",
//         "Вау. Это всё на что вы способны?",
//         "Я покажу вам на что я способна.",
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