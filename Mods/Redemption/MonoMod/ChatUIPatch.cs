// using System;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using Redemption.UI.ChatUI;
//
// namespace CalamityRuTranslate.Mods.Redemption.MonoMod;
//
// public class ChatUIPatch : OnPatcher
// {
//     public override bool AutoLoad => ModInstances.Redemption != null/* && TRuConfig.Instance.RedemptionLocalization*/ && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(ChatUI).GetCachedMethod(nameof(ChatUI.Add));
//
//     private delegate void AddDelegate(IDialogue dialogue);
//
//     public override Delegate Delegate => Translation;
//     
//     private void Translation(AddDelegate orig, IDialogue dialogue)
//     {
//         dialogue.Get().text = dialogue.Get().text switch
//         {
//             "Oru'takh!" => "Ору'тах",
//             "Eye beam!" => "Лазер!",
//             "Oof![0.3] Darn mops hittin' my noggin!" => "Уф![0.3] Чёртовы швабры бьют по макушке!",
//             "Owch![0.3] Darn mops hittin' my noggin!" => "Ой![0.3] Чёртовы швабры бьют по макушке!",
//             "Yowch![0.3] Darn mops hittin' my noggin!" => "Ай-ай![0.3] Чёртовы швабры бьют по макушке!",
//             "Ow![0.3] Darn mops hittin' my noggin!" => "Ох![0.3] Чёртовы швабры бьют по макушке!",
//             "Arg![0.3] Darn mops hittin' my noggin!" => "Арг![0.3] Чёртовы швабры бьют по макушке!",
//             "Damn it![0.3] Darn mops hittin' my noggin!" => "Чёрт побери![0.3] Чёртовы швабры бьют по макушке!",
//             "Ah!" => "Ах!",
//             "D'oh!" => "Д'ох!",
//             "Oops!" => "Упс!",
//             "Whoops!" => "Ой-ой!",
//             "Not again!" => "Только не снова!",
//             "Damn it!" => "Чёрт возьми!",
//             "Mur yeborti?" => "Мур йеборти?",
//             "Gorhal'on..." => "Горхал'он...",
//             "Mur sium'roro?[0.2] Bidu'oque, khru!" => "Мур сиум'роро?[0.2] Биду'окве, хру!",
//             "Gor'on!" => "Гор'он!",
//             "[@d]Mubirok abo,[0.2][@c] lo tasium ye!" => "[@d]Мубирок або,[0.2][@c] ло тасиум йе!",
//             ".^0.3^..^0.05^ [@e]Ta baadurlo ye." => ".^0.3^..^0.05^ [@e]Та баадурло йе.",
//             "Your fae says you're kind-hearted.[0.5] I will put it in good faith.[@End]" => "Твоя фея говорит, что у тебя доброе сердце.[0.5] Я поверю ей на слово.[@End]",
//             "Your fae tells me you're safe.[0.5] I'm still rather sceptical,[0.1] but I'll trust it's words.[@End]" => "Твоя фея уверяет меня, что ты безопасен.[0.5] Я всё ещё скептически настроена,[0.1] но поверю её словам.[@End]",
//             "Your fae just told me how pleasant you are.[0.5] A friend of nature is a friend of me.[@End]" => "Твоя фея только что рассказала мне, какой ты приятный.[0.5] Друг природы - мой друг.[@End]",
//             "Are you sure, fae?[0.5] This human doesn't look very kindly,[0.1] but I will trust your word.[@End]" => "Ты уверена, фея?[0.5] Этот человек не выглядит особо дружелюбным,[0.1] но я поверю твоему слову.[@End]",
//             "Your fae says you have a good heart.[0.5] I will be less wary of you from now on.[@End]" => "Твоя фея говорит, что у тебя доброе сердце.[0.5] Отныне я буду меньше остерегаться тебя.[@End]",
//             _ => dialogue.Get().text
//         };
//         
//         orig.Invoke(dialogue);
//     }
// }