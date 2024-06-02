// using System.Collections.Generic;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using Microsoft.Xna.Framework;
// using ReLogic.Utilities;
// using StarsAbove.Systems;
// using Terraria.Audio;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.StarsAbove.MonoMod;
//
// public class SoundEnginePatch : ILoadable
// {
//     private static StarsAboveAudio AudioInstance => ModContent.GetInstance<StarsAboveAudio>();
//
//     private Dictionary<SoundStyle, SoundStyle> _soundMap = new()
//     {
//         { AudioInstance.AS1, StarsAboveSounds.AS1 },
//         { AudioInstance.AS2, StarsAboveSounds.AS2 },
//         { AudioInstance.AS3, StarsAboveSounds.AS3 },
//         { AudioInstance.AS4, StarsAboveSounds.AS4 },
//         { AudioInstance.AS5, StarsAboveSounds.AS5 },
//         { AudioInstance.AS6, StarsAboveSounds.AS6 },
//         { AudioInstance.AS7, StarsAboveSounds.AS7 },
//         { AudioInstance.AS8, StarsAboveSounds.AS8 },
//         { AudioInstance.AS9, StarsAboveSounds.AS9 },
//         { AudioInstance.AS10, StarsAboveSounds.AS10 },
//         { AudioInstance.AS11, StarsAboveSounds.AS11 },
//         { AudioInstance.AS12, StarsAboveSounds.AS12 },
//         { AudioInstance.AS13, StarsAboveSounds.AS13 },
//         { AudioInstance.AS14, StarsAboveSounds.AS14 },
//         { AudioInstance.AS15, StarsAboveSounds.AS15 },
//         { AudioInstance.AS16, StarsAboveSounds.AS16 },
//         { AudioInstance.AS17, StarsAboveSounds.AS17 },
//         { AudioInstance.AS18, StarsAboveSounds.AS18 },
//         { AudioInstance.ASJoke, StarsAboveSounds.ASJoke },
//         { AudioInstance.ER1, StarsAboveSounds.ER1 },
//         { AudioInstance.ER2, StarsAboveSounds.ER2 },
//         { AudioInstance.ER3, StarsAboveSounds.ER3 } ,
//         { AudioInstance.ER4, StarsAboveSounds.ER4 },
//         { AudioInstance.ER5, StarsAboveSounds.ER5 },
//         { AudioInstance.ER6, StarsAboveSounds.ER6 },
//         { AudioInstance.ER7, StarsAboveSounds.ER7 },
//         { AudioInstance.ER8, StarsAboveSounds.ER8 },
//         { AudioInstance.ER9, StarsAboveSounds.ER9 },
//         { AudioInstance.ER10, StarsAboveSounds.ER10 },
//         { AudioInstance.ER11, StarsAboveSounds.ER11 },
//         { AudioInstance.ER12, StarsAboveSounds.ER12 },
//         { AudioInstance.ER13, StarsAboveSounds.ER13 },
//         { AudioInstance.ER14, StarsAboveSounds.ER14 },
//         { AudioInstance.ER15, StarsAboveSounds.ER15 },
//         { AudioInstance.ER16, StarsAboveSounds.ER16 },
//         { AudioInstance.ER17, StarsAboveSounds.ER17 },
//         { AudioInstance.ER18, StarsAboveSounds.ER18 },
//         { AudioInstance.ERJoke, StarsAboveSounds.ERJoke },
//         { StarsAboveAudio.StarfarerBoss_Intro, StarsAboveSounds.StarfarerBoss_Intro },
//     };
//     
//     public bool IsLoadingEnabled(Mod mod)
//     {
//         return ModInstances.StarsAbove != null && TranslationHelper.IsRussianLanguage;
//     }
//
//     public void Load(Mod mod)
//     {
//         On_SoundEngine.PlaySound_refSoundStyle_Nullable1_SoundUpdateCallback += On_SoundEngineOnPlaySoundRefSoundStyleNullable1SoundUpdateCallback;
//     }
//
//     public void Unload()
//     {
//         On_SoundEngine.PlaySound_refSoundStyle_Nullable1_SoundUpdateCallback -= On_SoundEngineOnPlaySoundRefSoundStyleNullable1SoundUpdateCallback;
//     }
//     
//     private SlotId On_SoundEngineOnPlaySoundRefSoundStyleNullable1SoundUpdateCallback(On_SoundEngine.orig_PlaySound_refSoundStyle_Nullable1_SoundUpdateCallback orig, ref SoundStyle style, Vector2? position, SoundUpdateCallback updatecallback)
//     {
//         if (_soundMap.TryGetValue(style, out SoundStyle newStyle))
//         {
//             style = newStyle;
//         }
//
//         return orig.Invoke(ref style, position, updatecallback);
//     }
// }