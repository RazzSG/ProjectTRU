﻿using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Fargowiltas.NPCs;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Fargowiltas;

public class FargoTownNpcNames : GlobalNPC
{
    private static Dictionary<int, List<string>> _townNpcNames = new()
    {
        { ModContent.NPCType<Abominationn>(), new List<string> { "Вилта", "Джек", "Харли", "Жнец", "Стивенн", "Дуф", "Бару", "Фергус", "Энтев", "Катастроф", "Бардо", "Бетсон" } },
        { ModContent.NPCType<Deviantt>(), new List<string> { "Акира", "Реми", "Саку", "Сейра", "Кои", "Элли", "Лори", "Калия", "Тери", "Артт", "Флан", "Сион", "Тьюи" } },
        { ModContent.NPCType<LumberJack>(), new List<string> { "Грифф", "Джек", "Брюс", "Ларри", "Уилл", "Джерри", "Лиам", "Стэн", "Ли", "Вуди", "Лейф", "Пауло" } },
        { ModContent.NPCType<Mutant>(), new List<string> { "Флакен", "Дорф", "Бинго", "Ханс", "Фарго", "Грим", "Майк", "Фаргу", "Терренс", "Кэтти Н. Пэм", "Том", "Вердус", "Полли" } },
        { ModContent.NPCType<Squirrel>(), new List<string> { "Рик", "Жёлудь", "Пуфф", "Коко", "Трюфель", "Фурго", "Пискун" } }
    };
    
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModsCall.Fargo != null && TranslationHelper.IsRussianLanguage;
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