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
        if (npc.type == NPCID.DukeFishron)
        {
            if (npc.GivenName == "Duke Fishron EX")
            {
                npc.GivenName = "Герцог Рыброн ЕХ";
            }
        }
        if (npc.type is NPCID.SolarCrawltipedeHead or NPCID.SolarCrawltipedeBody or NPCID.SolarCrawltipedeTail)
        {
            if (npc.GivenName == "John Crawltipede")
            {
                npc.GivenName = "Джон Ползотычинк";
            }
        }
        if (npc.type is NPCID.CultistDragonHead or NPCID.CultistDragonBody1 or NPCID.CultistDragonBody2 or NPCID.CultistDragonBody3 or NPCID.CultistDragonBody4 or NPCID.CultistDragonTail)
        {
            if (npc.GivenName == "Stardust Dragon")
            {
                npc.GivenName = "Призрачный дракон";
            }
        }
    }
}