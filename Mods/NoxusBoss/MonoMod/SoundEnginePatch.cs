﻿using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Microsoft.Xna.Framework;
using NoxusBoss.Content.NPCs.Bosses.NamelessDeity;
using ReLogic.Utilities;
using Terraria.Audio;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.NoxusBoss.MonoMod;

public class SoundEnginePatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;
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
        if (style == NamelessDeityBoss.DoNotVoiceActedSound)
            style = NoxusBossSounds.DoNotVoiceActedSound;
        
        return orig.Invoke(ref style, position, updatecallback);
    }
}