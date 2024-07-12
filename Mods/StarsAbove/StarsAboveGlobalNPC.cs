using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using StarsAbove.NPCs.TownNPCs;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.StarsAbove;

public partial class StarsAboveGlobalNPC : GlobalNPC
{
    private static Dictionary<int, List<string>> _townNpcNames = new()
    {
        { ModContent.NPCType<Astrologian>(),
            [
                "Одетта", "Астеропа", "Майя", "Тайгета", "Целено", "Алкиона",
                "Меропа","Электра", "Селена", "Сана", "Тиферет", "Лунала"
            ]
        },
        { ModContent.NPCType<Garridine>(), ["Гарридина"] },
        { ModContent.NPCType<Yojimbo>(), ["Йодзимбо"] },
    };
    
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization && TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyNPCNameList(NPC npc, List<string> nameList)
    {
        if (_townNpcNames.TryGetValue(npc.type, out List<string> names))
        {
            nameList.Clear();
            nameList.AddRange(names);
        }
    }

    public override void Unload()
    {
        _townNpcNames?.Clear();
        _townNpcNames = null;
    }
}