// using CalamityRuTranslate.Common;
// using CalamityRuTranslate.Common.Utilities;
// using CalamityRuTranslate.Core.Config;
// using Microsoft.Xna.Framework.Media;
// using ReLogic.Content;
// using Terraria.ModLoader;
//
// namespace CalamityRuTranslate.Mods.StarsAbove;
//
// public class StarsAboveCutscene : ModSystem
// {
//     public static Asset<Video> TsukiCutsceneVideo;
//
//     public override bool IsLoadingEnabled(Mod mod)
//     {
//         return ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization && TranslationHelper.IsRussianLanguage;
//     }
//
//     public override void Load()
//     {
//         TsukiCutsceneVideo = Mod.Assets.Request<Video>("Assets/Video/TsukiyomiBossCutscene", AssetRequestMode.ImmediateLoad);
//     }
// }