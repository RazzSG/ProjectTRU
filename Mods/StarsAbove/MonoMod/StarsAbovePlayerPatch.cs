// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using MonoMod.Cil;
// using StarsAbove;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove.MonoMod;
//
// public class StarsAbovePlayerOnEnterWorld : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(StarsAbovePlayer).GetCachedMethod(nameof(StarsAbovePlayer.OnEnterWorld));
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, " has been binded to ", " был связан с миром: ");
//         TranslationHelper.ModifyIL(il, "The Stars Above progression will only occur on this world. (Check Mod Settings if necessary)", "");
//         TranslationHelper.ModifyIL(il, " has already been binded to ", "");
//         TranslationHelper.ModifyIL(il, ". (World ID ", "");
//         TranslationHelper.ModifyIL(il, " has already been binded to World ID ", "");
//         TranslationHelper.ModifyIL(il, "Disable the client-side configuration option 'Enable Player Progress World Lock' to enable The Stars Above progression on this world.", "");
//     };
// }
//
// public class StarsAbovePlayerStellarDiskDialogue : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(StarsAbovePlayer).GetMethod("StellarDiskDialogue", BindingFlags.Instance | BindingFlags.NonPublic);
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "Stellar Novas have been unlocked!", "Астроновы разблокированы!");
//     };
// }
//
// public class StarsAbovePlayerStellarNovaSetup : ILPatcher
// {
//     public override bool AutoLoad => ModsCall.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//
//     public override MethodInfo ModifiedMethod => typeof(StarsAbovePlayer).GetMethod("StellarNovaSetup", BindingFlags.Instance | BindingFlags.NonPublic);
//
//     public override ILContext.Manipulator PatchMethod { get; } = il =>
//     {
//         TranslationHelper.ModifyIL(il, "The Stellar Array reaches new heights!", "Созвездия достигают новых высот!");
//     };
// }
//
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