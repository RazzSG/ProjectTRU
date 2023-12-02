using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.BossIntroScreens;
using ReLogic.Graphics;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class BaseIntroScreenPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(BaseIntroScreen).GetCachedMethod("get_FontToUse");
    
    private delegate DynamicSpriteFont FontToUseDelegate();

    public override Delegate Delegate => Translation;
    
    private DynamicSpriteFont Translation(FontToUseDelegate orig)
    {
        return InfernumModeSystem.BossIntroScreensFont;
    }
}