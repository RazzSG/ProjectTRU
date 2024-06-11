// using System;
// using System.Reflection;
// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.MonoMod;
// using Microsoft.Xna.Framework.Media;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.StarsAbove.MonoMod;
//
// public class VideoPlayerPatch : OnPatcher
// {
//     public override bool AutoLoad => ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization && TranslationHelper.IsRussianLanguage;
//     
//     public override MethodInfo ModifiedMethod => typeof(VideoPlayer).GetCachedMethod(nameof(VideoPlayer.Play));
//
//     private delegate void PlayDelegate(VideoPlayer self, Video video);
//     
//     public override Delegate Delegate => Translation;
//
//     private void Translation(PlayDelegate orig, VideoPlayer self, Video video)
//     {
//         if (video == ModContent.Request<Video>("StarsAbove/Video/TsukiyomiBossCutscene").Value)
//         {
//             video = StarsAboveCutscene.TsukiCutsceneVideo.Value;
//         }
//         
//         orig.Invoke(self, video);
//     }
// }