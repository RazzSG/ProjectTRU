using CalamityMod.Buffs.StatDebuffs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.NoxusBoss;

public class NoxusBossGlobalBuff : GlobalBuff
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.NoxusBoss != null && TRuConfig.Instance.NoxusBossLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyBuffText(int type, ref string buffName, ref string tip, ref int rare)
    {
        if (type == ModContent.BuffType<Enraged>())
        {
            tip = tip.Replace("125", "50").Replace("25", "50");
        }
    }
}