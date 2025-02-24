using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using NoxusBoss.Assets.Fonts;
using ReLogic.Content;
using ReLogic.Graphics;

namespace CalamityRuTranslate.Mods.NoxusBoss.MonoMod;

public class DraedonTextPatch : OnPatcher
{
    private delegate DynamicSpriteFont DraedonTextDelegate(FontRegistry self);

    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_DraedonText");

    public override Delegate Delegate => Translation;
    
    private DynamicSpriteFont Translation(DraedonTextDelegate orig, FontRegistry self)
    {
        return CalamityRuTranslate.Instance.Assets.Request<DynamicSpriteFont>("Assets/Fonts/Item_Stack", AssetRequestMode.ImmediateLoad).Value;
    }
}

public class NamelessDeityTextPatch : OnPatcher
{
    private delegate DynamicSpriteFont NamelessDeityTextDelegate(FontRegistry self);

    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_NamelessDeityText");

    public override Delegate Delegate => Translation;
    
    private DynamicSpriteFont Translation(NamelessDeityTextDelegate orig, FontRegistry self)
    {
        return CalamityRuTranslate.Instance.Assets.Request<DynamicSpriteFont>("Assets/Fonts/FairyMuffinRoundPop", AssetRequestMode.ImmediateLoad).Value;
    }
}