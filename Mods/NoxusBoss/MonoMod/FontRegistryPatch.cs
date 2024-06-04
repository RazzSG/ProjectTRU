using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using NoxusBoss.Assets.Fonts;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria.GameContent;

namespace CalamityRuTranslate.Mods.NoxusBoss.MonoMod;

public class FontRegistryPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FontRegistry).GetCachedMethod("get_NamelessDeityText");

    private delegate DynamicSpriteFont NamelessDeityText(FontRegistry self);

    public override Delegate Delegate => ReplaceFont;
    
    private DynamicSpriteFont ReplaceFont(NamelessDeityText orig, FontRegistry self)
    {
        if (FontRegistry.CanLoadFonts)
            return CalamityRuTranslate.Instance.Assets.Request<DynamicSpriteFont>("Assets/Fonts/FairyMuffinRoundPop", AssetRequestMode.ImmediateLoad).Value;

        return FontAssets.MouseText.Value;
    }
}