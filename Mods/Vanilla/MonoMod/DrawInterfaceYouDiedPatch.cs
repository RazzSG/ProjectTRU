using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class DrawInterfaceYouDiedPatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage && TRuConfig.Instance.RandomDeathText;
    }

    public void Load(Mod mod)
    {
        IL_Main.DrawInterface_35_YouDied += MainOnDrawInterface_35_YouDied;
    }

    public void Unload()
    {
        IL_Main.DrawInterface_35_YouDied -= MainOnDrawInterface_35_YouDied;
    }
    
    private void MainOnDrawInterface_35_YouDied(ILContext il)
    {
        ILCursor cursor = new ILCursor(il);

        cursor.TryGotoNext(i => i.MatchLdsfld<Lang>("inter"));
        cursor.TryGotoNext(i => i.MatchLdloc(1));
        cursor.Index++;
        cursor.Emit(OpCodes.Pop);
        cursor.Emit(OpCodes.Ldsfld, typeof(RandomDeathTextPlayer).GetField("RandomDeathText"));
        cursor.TryGotoNext(i => i.MatchLdloc(1));
        cursor.Index++;
        cursor.Emit(OpCodes.Pop);
        cursor.Emit(OpCodes.Ldsfld, typeof(RandomDeathTextPlayer).GetField("RandomDeathText"));
    }
}