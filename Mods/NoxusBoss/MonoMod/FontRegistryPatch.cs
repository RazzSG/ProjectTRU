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

public class SolynTextPatch : OnPatcher
{
    private delegate DynamicSpriteFont SolynTextDelegate(FontRegistry self);

    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_SolynText");

    public override Delegate Delegate => Translation;
    
    private DynamicSpriteFont Translation(SolynTextDelegate orig, FontRegistry self)
    {
        return CalamityRuTranslate.Instance.Assets.Request<DynamicSpriteFont>("Assets/Fonts/Death_Text", AssetRequestMode.ImmediateLoad).Value;
    }
}

public class SolynTextItalicsPatch : OnPatcher
{
    private delegate DynamicSpriteFont SolynTextItalicsDelegate(FontRegistry self);

    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_SolynTextItalics");

    public override Delegate Delegate => Translation;
    
    private DynamicSpriteFont Translation(SolynTextItalicsDelegate orig, FontRegistry self)
    {
        return CalamityRuTranslate.Instance.Assets.Request<DynamicSpriteFont>("Assets/Fonts/SolynTextItalics", AssetRequestMode.ImmediateLoad).Value;
    }
}

public class SolynFightDialoguePatch : OnPatcher
{
    private delegate DynamicSpriteFont SolynFightDialogueDelegate(FontRegistry self);

    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_SolynFightDialogue");

    public override Delegate Delegate => Translation;
    
    private DynamicSpriteFont Translation(SolynFightDialogueDelegate orig, FontRegistry self)
    {
        return CalamityRuTranslate.Instance.Assets.Request<DynamicSpriteFont>("Assets/Fonts/SolynFightDialogue", AssetRequestMode.ImmediateLoad).Value;
    }
}

public class AvatarPoemTextPatch : OnPatcher
{
    private delegate DynamicSpriteFont AvatarPoemTextDelegate(FontRegistry self);

    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_AvatarPoemText");

    public override Delegate Delegate => Translation;
    
    private DynamicSpriteFont Translation(AvatarPoemTextDelegate orig, FontRegistry self)
    {
        return CalamityRuTranslate.Instance.Assets.Request<DynamicSpriteFont>("Assets/Fonts/AvatarPoemText", AssetRequestMode.ImmediateLoad).Value;
    }
}