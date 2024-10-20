﻿using CalamityMod.NPCs.TownNPCs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.CalamityMod;

public class CalamityModGlobalNPC : GlobalNPC
{
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void GetChat(NPC npc, ref string chat)
    {
        if (npc.type == NPCID.Stylist)
        {
            if (chat.Contains("Прошу, не цепляй космических вшей"))
            {
                chat = chat.Replace("Багрянец", "багряных");
                chat = chat.Replace("Искажение", "искажённых");
            }
        }

        if (npc.type == ModContent.NPCType<SEAHOE>())
        {
            if (chat.Contains("Будь осторожен, когда атакуешь что-то в"))
            {
                chat = chat.Replace("Багрянец", "багрянце");
                chat = chat.Replace("Искажение", "искажении");
            }
        }
    }
}