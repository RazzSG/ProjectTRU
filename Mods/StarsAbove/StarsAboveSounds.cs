// using System;
// using Terraria.Audio;
//
// namespace CalamityRuTranslate.Mods.TheStarsAbove;
//
// public class StarsAboveSounds
// {
//     public static readonly SoundStyle Penthesilea_AlrightMyTurn = GetSoundStyle("Penthesilea/AlrightMyTurn");
//     public static readonly SoundStyle Penthesilea_CutThrough = GetSoundStyle("Penthesilea/CutThrough");
//     public static readonly SoundStyle Penthesilea_Enough = GetSoundStyle("Penthesilea/Enough");
//     public static readonly SoundStyle Penthesilea_HowFoolish = GetSoundStyle("Penthesilea/HowFoolish");
//     public static readonly SoundStyle Penthesilea_HowFun = GetSoundStyle("Penthesilea/HowFun");
//     public static readonly SoundStyle Penthesilea_INeedntHoldBack = GetSoundStyle("Penthesilea/INeedntHoldBack");
//     public static readonly SoundStyle Penthesilea_ISenseTheirResolve = GetSoundStyle("Penthesilea/ISenseTheirResolve");
//     public static readonly SoundStyle Penthesilea_IveEnduredFarWorse = GetSoundStyle("Penthesilea/IveEnduredFarWorse");
//     public static readonly SoundStyle Penthesilea_OutOfMyWay = GetSoundStyle("Penthesilea/OutOfMyWay");
//     public static readonly SoundStyle Penthesilea_PenthLaugh = GetSoundStyle("Penthesilea/PenthLaugh");
//     public static readonly SoundStyle Penthesilea_QuickQuick = GetSoundStyle("Penthesilea/QuickQuick");
//     public static readonly SoundStyle Penthesilea_ThisllCheerMeUp = GetSoundStyle("Penthesilea/ThisllCheerMeUp");
//     public static readonly SoundStyle Penthesilea_ToPieces = GetSoundStyle("Penthesilea/ToPieces");
//     public static readonly SoundStyle Penthesilea_ToShreds = GetSoundStyle("Penthesilea/ToShreds");
//     public static readonly SoundStyle Penthesilea_TryAgainIDareYou = GetSoundStyle("Penthesilea/TryAgainIDareYou");
//     public static readonly SoundStyle Penthesilea_WithHaste = GetSoundStyle("Penthesilea/WithHaste");
//     public static readonly SoundStyle Penthesilea_WhateverItTakes = GetSoundStyle("Penthesilea/WhateverItTakes");
//     
//     public static readonly SoundStyle Arbitration_ABlightTakesThisLand = GetSoundStyle("Arbitration/ABlightTakesThisLand");
//     public static readonly SoundStyle Arbitration_ArbiterGrunt = GetSoundStyle("Arbitration/ArbiterGrunt");
//     public static readonly SoundStyle Arbitration_ArbiterLaugh = GetSoundStyle("Arbitration/ArbiterLaugh", new[] { 1, 2, 3, 4 });
//     public static readonly SoundStyle Arbitration_DepriveThemOfLife = GetSoundStyle("Arbitration/DepriveThemOfLife");
//     public static readonly SoundStyle Arbitration_DespairInOurPresence = GetSoundStyle("Arbitration/DespairInOurPresence");
//     public static readonly SoundStyle Arbitration_FateCanNotBeAverted = GetSoundStyle("Arbitration/FateCanNotBeAverted");
//     public static readonly SoundStyle Arbitration_FulfillDestiny = GetSoundStyle("Arbitration/FulfillDestiny");
//     public static readonly SoundStyle Arbitration_LongHaveWeWaited = GetSoundStyle("Arbitration/LongHaveWeWaited");
//     public static readonly SoundStyle Arbitration_Oblivion = GetSoundStyle("Arbitration/Oblivion");
//     public static readonly SoundStyle Arbitration_PierceTheVeil = GetSoundStyle("Arbitration/PierceTheVeil");
//     public static readonly SoundStyle Arbitration_SoItMustBe = GetSoundStyle("Arbitration/SoItMustBe");
//     public static readonly SoundStyle Arbitration_TheEndOfDaysDrawsNear = GetSoundStyle("Arbitration/TheEndOfDaysDrawsNear");
//     public static readonly SoundStyle Arbitration_TheFirstAreWeTheLastAreWe = GetSoundStyle("Arbitration/TheFirstAreWeTheLastAreWe");
//     public static readonly SoundStyle Arbitration_TheyAreRightToFear = GetSoundStyle("Arbitration/TheyAreRightToFear");
//     public static readonly SoundStyle Arbitration_WasIsAndWillForeverBe = GetSoundStyle("Arbitration/WasIsAndWillForeverBe");
//     public static readonly SoundStyle Arbitration_WeTranscendTime = GetSoundStyle("Arbitration/WeTranscendTime");
//
//     private static SoundStyle GetSoundStyle(string soundName, ReadOnlySpan<int> variants = default)
//     {
// 	    string path = $"{nameof(CalamityRuTranslate)}/Sounds/VoiceLines/";
// 	    return new(path + soundName)
// 	    {
// 		    Variants = variants
// 	    };
//     }
// }