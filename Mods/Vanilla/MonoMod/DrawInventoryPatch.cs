using CalamityRuTranslate.Common.Utilities;
using MonoMod.Cil;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class DrawInventoryPatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        IL_Main.DrawInventory += IL_MainOnDrawInventory;
    }
    
    public void Unload()
    {
        IL_Main.DrawInventory -= IL_MainOnDrawInventory;
    }
    
    private void IL_MainOnDrawInventory(ILContext il)
    {
        TranslationHelper.ModifyIL(il, 0.75f, 1.2f, 5); // scale
        TranslationHelper.ModifyIL(il, 84f, 81f, 2); // Y position
    }
}