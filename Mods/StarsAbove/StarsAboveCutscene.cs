using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Microsoft.Xna.Framework.Media;
using ReLogic.Content;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.StarsAbove;

public class StarsAboveCutscene : ModSystem
{
    public static Asset<Video> TsukiCutsceneVideo;
    public static Asset<Video> NalhaunBossCutscene;
    public static Asset<Video> WarriorIntroCutscene;
    public static Asset<Video> WarriorFinalPhaseCutscene;

    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void Load()
    {
        TsukiCutsceneVideo = Mod.Assets.Request<Video>("Assets/Video/TsukiyomiBossCutscene", AssetRequestMode.ImmediateLoad);
        NalhaunBossCutscene = Mod.Assets.Request<Video>("Assets/Video/NalhaunBossCutscene", AssetRequestMode.ImmediateLoad);
        WarriorIntroCutscene = Mod.Assets.Request<Video>("Assets/Video/WarriorIntroCutscene", AssetRequestMode.ImmediateLoad);
        WarriorFinalPhaseCutscene = Mod.Assets.Request<Video>("Assets/Video/WarriorFinalPhaseCutscene", AssetRequestMode.ImmediateLoad);
    }

    public override void Unload()
    {
        TsukiCutsceneVideo = null;
        NalhaunBossCutscene = null;
        WarriorIntroCutscene = null;
        WarriorFinalPhaseCutscene = null;
    }
}