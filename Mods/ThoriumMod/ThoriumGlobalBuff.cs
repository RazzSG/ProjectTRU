using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;
using ThoriumMod;
using ThoriumMod.Buffs.Healer;
using ThoriumMod.Utilities;

namespace CalamityRuTranslate.Mods.ThoriumMod;

public class ThoriumGlobalBuff : GlobalBuff
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Thorium != null && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyBuffText(int type, ref string buffName, ref string tip, ref int rare)
    {
        ThoriumPlayer thoriumPlayer = Main.LocalPlayer.GetThoriumPlayer();
        
        if (type == ModContent.BuffType<SoulEssence>())
        {
            tip = $"При достижении 5 стаков субстанции души вы восстанавливаете ({1 + thoriumPlayer.healBonus}) ед. здоровья и ({3 + thoriumPlayer.healBonus * 3}) ед. маны";
        }
    }
}