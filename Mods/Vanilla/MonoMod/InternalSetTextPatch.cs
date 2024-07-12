using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Mods.StarsAbove;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class InternalSetTextPatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        On_UIText.InternalSetText += On_UITextOnInternalSetText;
    }
    
    public void Unload()
    {
        On_UIText.InternalSetText -= On_UITextOnInternalSetText;
    }
    
    private void On_UITextOnInternalSetText(On_UIText.orig_InternalSetText orig, UIText self, object text, float textscale, bool large)
    {
        if (ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization)
        {
            if (StarsAboveSystem.NovaUIActive)
            {
                if (textscale == 0.8f)
                    textscale = 0.63f;
            }
            
            if (StarsAboveSystem.StarfarerDialogueActive)
            {
                if (textscale == 1.2f)
                    textscale = 1.05f;
            }
            
            if (StarsAboveSystem.VNDialogueActive)
            {
                if (textscale == 1.2f)
                    textscale = 1.05f;
            }
        }

        orig.Invoke(self, text, textscale, large);
    }
}