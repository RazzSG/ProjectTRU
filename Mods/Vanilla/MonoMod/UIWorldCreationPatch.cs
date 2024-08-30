using System.Reflection;
using CalamityRuTranslate.Common.Utilities;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.ModLoader;
using Terraria.UI;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class UIWorldCreationPatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        IL_UIWorldCreation.AddDescriptionPanel += IL_UIWorldCreationOnAddDescriptionPanel;
    }

    public void Unload()
    {
        IL_UIWorldCreation.AddDescriptionPanel -= IL_UIWorldCreationOnAddDescriptionPanel;
    }
    
    private void IL_UIWorldCreationOnAddDescriptionPanel(ILContext il)
    {
        ILCursor cursor = new ILCursor(il);
        cursor.TryGotoNext(MoveType.After, x => x.MatchStfld<UIElement>("PaddingTop"));
        cursor.Emit(OpCodes.Ldloc_2);
        cursor.Emit(OpCodes.Ldc_I4_1);
        cursor.Emit(OpCodes.Callvirt, typeof(UIText).GetMethod("set_IsWrapped", BindingFlags.Instance | BindingFlags.Public)!);
        
        TranslationHelper.ModifyIL(il, 6f, 0f);
    }
}