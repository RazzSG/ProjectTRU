using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.FargowiltasSouls;

public class FargowiltasSoulsGlobalNPC : GlobalNPC
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.FargowiltasSouls != null && TranslationHelper.IsRussianLanguage;
    }

    public override void AI(NPC npc)
    {
        if (npc.type is NPCID.SolarCrawltipedeHead or NPCID.SolarCrawltipedeBody or NPCID.SolarCrawltipedeTail)
        {
            if (npc.GivenName == "John Crawltipede")
            {
                npc.GivenName = "Джон Ползотычинк";
            }
        }
    }
}