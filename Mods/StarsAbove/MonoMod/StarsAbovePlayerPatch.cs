// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using StarsAbove;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;

// public class StarsAbovePlayerPreKill : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(StarsAbovePlayer).GetCachedMethod(nameof(StarsAbovePlayer.PreKill));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, " died beyond their world.", "");
//         TranslationHelper.ModifyIL(il, " was lost in space.", "");
//         TranslationHelper.ModifyIL(il, " drifted away from their home planet.", "");
//         TranslationHelper.ModifyIL(il, " was brought to kneel beyond their world.", "");
//         TranslationHelper.ModifyIL(il, " died within another realm.", "");
//         TranslationHelper.ModifyIL(il, " was struck down during their duel with The Warrior Of Light.", " был сражён во время дуэли с Воином Света.");
//         TranslationHelper.ModifyIL(il, " faltered during their fight with the Witch of Ink.", " дрогнул во время битвы с Ведьмой чернил.");
//         TranslationHelper.ModifyIL(il, " was cleaved in twain by the Burnished King.", " был располовинен Воронёным королём.");
//         TranslationHelper.ModifyIL(il, " was found wanting.", " был признан жаждущим.");
//         TranslationHelper.ModifyIL(il, " has been completely reduced to elementary particles.", " был полностью разложен на элементарные частицы.");
//         TranslationHelper.ModifyIL(il, " was rent asunder by the Vagrant of Space and Time.", " был разорван на части Ходящим между пространством и временем.");
//         TranslationHelper.ModifyIL(il, " couldn't handle the vacuum of space.", " не выдержал вакуума космоса.");
//     };
// }