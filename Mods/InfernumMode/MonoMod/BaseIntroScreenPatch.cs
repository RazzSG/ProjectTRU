﻿using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.BossIntroScreens;
using ReLogic.Graphics;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

[JITWhenModsEnabled("InfernumMode", "CalamityMod")]
public class BaseIntroScreenPatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Infernum != null && ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(BaseIntroScreen).GetCachedMethod("get_FontToUse");
    
    private delegate DynamicSpriteFont FontToUseDelegate();

    public override Delegate Delegate => Translation;
    
    private DynamicSpriteFont Translation(FontToUseDelegate orig)
    {
        return CalamityRuTranslate.Instance.BossIntroScreensFont;
    }
}