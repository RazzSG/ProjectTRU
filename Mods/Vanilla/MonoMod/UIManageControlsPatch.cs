using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.GameContent.UI.States;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class UIManageControlsPatch : ILoadable
{
    private UIElement OuterContainer => Main.ManageControlsMenu.GetFieldValue<UIManageControls, UIElement>("_outerContainer");

    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage && !Main.dedServ;
    }
    
    public void Load(Mod mod)
    {
        // Исправляет баг с двойным UI
        Main.ManageControlsMenu.RemoveAllChildren();
        Main.ManageControlsMenu.Initialize();
        OuterContainer?.Width.Set(700f, 0.8f);
        OuterContainer?.MaxWidth.Set(700f, 0f);
    }

    public void Unload()
    {
        OuterContainer?.Width.Set(600f, 0.8f);
        OuterContainer?.MaxWidth.Set(600f, 0f);
    }
}