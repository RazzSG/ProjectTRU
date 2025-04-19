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
    public override bool AutoLoad => ModInstances.Calamity != null && ModInstances.CalamityModMusic != null && TranslationHelper.IsRussianLanguage && TRuConfig.Instance.YharonCover && TRuConfig.Instance.CalamityModLocalization;
    
    public override MethodInfo ModifiedMethod => typeof(YharonPhase2MusicScene).FindMethod("get_MusicModMusic");

    public override Delegate Delegate => ReplaceMusic;

    private int? ReplaceMusic(Func<YharonPhase2MusicScene, int?> _, YharonPhase2MusicScene self)
    {
        return MusicLoader.GetMusicSlot(CalamityRuTranslate.Instance, "Assets/Sounds/Music/Calamity/YharonPhase2");
    }
}