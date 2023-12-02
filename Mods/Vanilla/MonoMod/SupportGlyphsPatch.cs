using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class SupportGlyphsPatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        On_Lang.SupportGlyphs += On_LangOnSupportGlyphs;
    }

    public void Unload()
    {
        On_Lang.SupportGlyphs -= On_LangOnSupportGlyphs;
    }
    
    private string On_LangOnSupportGlyphs(On_Lang.orig_SupportGlyphs orig, string tooltip)
    {
        string result = orig.Invoke(tooltip);

        if (result.Contains("<up>"))
        {
            result = result.Replace("<up>", Language.GetTextValue("Key.UP"));
        }

        if (result.Contains("<down>"))
        {
            result = result.Replace("<down>", Language.GetTextValue("Key.DOWN"));
        }

        return result;
    }
}