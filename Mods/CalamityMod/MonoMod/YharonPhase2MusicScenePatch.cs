using System;
using System.Reflection;
using CalamityMod.Systems;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class YharonPhase2MusicScenePatch : OnPatcher
{
    private delegate int? MusicModMusicDelegate(YharonPhase2MusicScene self);
    
    public override bool AutoLoad => ModInstances.Calamity != null && ModInstances.CalamityModMusic != null && TranslationHelper.IsRussianLanguage && TRuConfig.Instance.YharonCover;
    
    public override MethodInfo ModifiedMethod => typeof(YharonPhase2MusicScene).GetCachedMethod("get_MusicModMusic");

    public override Delegate Delegate => ReplaceMusic;

    private int? ReplaceMusic(MusicModMusicDelegate _, YharonPhase2MusicScene self)
    {
        return MusicLoader.GetMusicSlot(CalamityRuTranslate.Instance, "Assets/Sounds/Music/Calamity/YharonPhase2");
    }
}