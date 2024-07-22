using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
// using CalamityRuTranslate.Mods.Redemption;
using CalamityRuTranslate.Mods.StarsAbove;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.Audio;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class SoundEnginePatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        On_SoundEngine.PlaySound_refSoundStyle_Nullable1_SoundUpdateCallback += On_SoundEngineOnPlaySoundRefSoundStyleNullable1SoundUpdateCallback;
    }

    public void Unload()
    {
        On_SoundEngine.PlaySound_refSoundStyle_Nullable1_SoundUpdateCallback -= On_SoundEngineOnPlaySoundRefSoundStyleNullable1SoundUpdateCallback;
    }
    
    private SlotId On_SoundEngineOnPlaySoundRefSoundStyleNullable1SoundUpdateCallback(On_SoundEngine.orig_PlaySound_refSoundStyle_Nullable1_SoundUpdateCallback orig, ref SoundStyle style, Vector2? position, SoundUpdateCallback updatecallback)
    {
        if (ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization)
        {
            if (StarsAboveSystem.SoundMap.TryGetValue(style, out SoundStyle newStyle))
            {
                style = newStyle;
            }
        }
        
        // if (ModInstances.Redemption != null && TRuConfig.Instance.RedemptionLocalization)
        // {
        //     if (RedemptionSystem.SoundMap.TryGetValue(style, out SoundStyle newStyle))
        //     {
        //         style = newStyle;
        //     }
        // }

        return orig.Invoke(ref style, position, updatecallback);
    }
}