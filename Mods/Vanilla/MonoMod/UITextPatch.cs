using CalamityRuTranslate.Common.Utilities;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class UITextPatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        On_UIText.SetText_string += On_UITextOnSetText_string;
    }

    public void Unload()
    {
        On_UIText.SetText_string -= On_UITextOnSetText_string;
    }

    private void On_UITextOnSetText_string(On_UIText.orig_SetText_string orig, UIText self, string text)
    {
        text = text switch
        {
            // Stars Above
            "Asphodene" => "Асфодена",
            "Eridani" => "Эридани",
            "Perseus" => "Персей",
            "Yojimbo" => "Йодзимбо",
            "Garridine" => "Гарридина",
            "Andyer" => "Андир",
            _ => text
        };
        
        orig.Invoke(self, text);
    }
}