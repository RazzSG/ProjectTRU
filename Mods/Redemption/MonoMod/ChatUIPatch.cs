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
//             "Oru'takh!" => "",
//             "Oof![0.3] Darn mops hittin' my noggin!" => "",
//             "Owch![0.3] Darn mops hittin' my noggin!" => "",
//             "Yowch![0.3] Darn mops hittin' my noggin!" => "",
//             "Ow![0.3] Darn mops hittin' my noggin!" => "",
//             "Arg![0.3] Darn mops hittin' my noggin!" => "",
//             "Damn it![0.3] Darn mops hittin' my noggin!" => "",
//             "Ah!" => "",
//             "D'oh!" => "",
//             "Oops!" => "",
//             "Whoops!" => "",
//             "Not again!" => "",
//             "Damn it!" => "",
//             "Mur yeborti?" => "",
//             "Gorhal'on..." => "",
//             "Mur sium'roro?[0.2] Bidu'oque, khru!" => "",
//             "Gor'on!" => "",
//             "[@d]Mubirok abo,[0.2][@c] lo tasium ye!" => "",
//             ".^0.3^..^0.05^ [@e]Ta baadurlo ye." => "",
//             "Your fae says you're kind-hearted.[0.5] I will put it in good faith.[@End]" => "",
//             "Your fae tells me you're safe.[0.5] I'm still rather sceptical,[0.1] but I'll trust it's words.[@End]" => "",
//             "Your fae just told me how pleasant you are.[0.5] A friend of nature is a friend of me.[@End]" => "",
//             "Are you sure, fae?[0.5] This human doesn't look very kindly,[0.1] but I will trust your word.[@End]" => "",
//             "Your fae says you have a good heart.[0.5] I will be less wary of you from now on.[@End]" => "",
//             _ => dialogue.Get().text
//         };
//         
//         orig.Invoke(dialogue);
//     }
// }