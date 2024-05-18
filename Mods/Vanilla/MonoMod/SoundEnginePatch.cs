// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Mods.StarsAbove;
// using Microsoft.Xna.Framework;  
// using ReLogic.Utilities;
// using StarsAbove.Systems;
// using Terraria;
// using Terraria.Audio;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;
//
// public class SoundEnginePatch : ILoadable
// {
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
//         StarsAboveAudio sounds = new StarsAboveAudio();
//         if (style == sounds.AS1)
//         {
//             style = StarsAboveSounds.AS1;
//         }
//
//         return  orig.Invoke(ref style, position, updatecallback);
//     }
// }