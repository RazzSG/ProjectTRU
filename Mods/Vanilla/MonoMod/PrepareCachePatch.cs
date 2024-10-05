using CalamityRuTranslate.Common.Utilities;
using MonoMod.Cil;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class PrepareCachePatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        IL_Main.TextDisplayCache.PrepareCache += TextDisplayCacheOnPrepareCache;
    }

    public void Unload()
    {
        IL_Main.TextDisplayCache.PrepareCache -= TextDisplayCacheOnPrepareCache;
    }
    
    private void TextDisplayCacheOnPrepareCache(ILContext il)
    {
        // расширяет милит на кол-во строк текста для Main.npcChatText
        TranslationHelper.ModifyIL(il, 10, 12);
    }
}