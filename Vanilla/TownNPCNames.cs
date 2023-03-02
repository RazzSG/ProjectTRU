﻿using System.Collections.Generic;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla;

public class TownNpcNames : GlobalNPC
{
    public override bool InstancePerEntity => true;

    private readonly Dictionary<string, string> _townNpcNames = new()
    {
        {"Dazren", "Дазрен"},
        {"Drifter", "Дрифтер"},
        {"Finchi", "Финчи"},
        {"Heniek", "Хеник"},
        {"Fire", "Фаер"},
        {"Barney Calhoun", "Барни Калхун"},
        {"XiaoEn0426", "СяоЭн0426"},
        {"Jeffred", "Джеффред"},
        {"The Cooler Arthur", "Крутой Артур"},
        {"Joeseph Jostar", "Джозеф Джостар"},
        {"Sylux", "Силикс"},
        {"Tavish DeGroot", "Тэвиш ДеГрут"},
        {"Rythmi", "Ритми"},
        {"Izuna", "Изуна"},
        {"Jasmine", "Жасмин"},
        {"Cybil", "Кибил"},
        {"Verth", "Верт"},
        {"Gormer", "Кормер"},
        {"TingFlarg", "ТингФларг"},
        {"Driser", "Драйзер"},
        {"Eddie Spaghetti", "Эдди Спагетти"},
        {"G'tok", "Г'ток"},
        {"Katto", "Катто"},
        {"Him", "Хим"},
        {"Lapp", "Лапп"},
        {"Ben Shapiro", "Бен Шапиро"},
        {"Streakist", "Стрикист"},
        {"Necroplasmic", "Некроплазмик"},
        {"Devin", "Девин"},
        {"Woffle", "Воффл"},
        {"Cameron", "Кэмерон"},
        {"Wilbur", "Уилбур"},
        {"Good Game Design", "иноп тибюл лосбаФ"},
        {"Danmaku", "Данмаку"},
        {"Lilly", "Лилли"},
        {"Daawn", "Даан"},
        {"Robin", "Робин"},
        {"Curly", "Кудряшка"},
        {"Farsni", "Фарсни"},
        {"Fanny", "Фанни"},
        {"Picasso", "Пикассо"},
        {"Arin", "Арин"},
        {"Tyler Van Hook", "Тайлер Ван Хук"},
        {"Cap'n Deek", "Кэп'н Дик"},
        {"Catalyst", "Каталист"},
        {"Sans Undertale", "Санс Андертейлов"},
        {"Papyrus Undertale", "Папирус Андертейлов"},
        {"Vorbis", "Ворбис"},
        {"Angel", "Энжел"},
        {"Amber", "Янтарь"},
        {"Faith", "Вера"},
        {"Xsiana", "Ксиана"},
        {"Tim Lockwood", "Тим Локвуд"},
        {"Sir Samuel Winchester Jenkins Kester II", "Сэр Сэмюэль Винчестер Дженкинс Кестер II"},
        {"Brutus", "Брутус"},
        {"Sloth", "Слот"},
        {"Emmett", "Эммет"},
        {"Stan Pines", "Стэн Пайнс"},
        {"Aldrimil", "Альдримил"},
        {"Sok'ar", "Сокар"},
        {"Toxin", "Токсин"},
        {"Mixcoatl", "Мишкоатль"},
        {"Khatunz", "Хатунц"},
        {"Amnesia Wapers", "Амнезия Вейперс"},
        {"Mage One-Trick", "Маг Трюкач"},
        {"Inorim, son of Ivukey", "Инорим, сын Ивукея"},
        {"Jensen", "Дженсен"},
        {"Merasmus", "Мерасмус"},
        {"Habolo", "Хаболо"},
        {"Ortho", "Орто"},
        {"Chris Tallballs", "Шаркрис Тальный"},
        {"Syethas", "Ситас"},
        {"Nextdoor Psycho", "Шизак Даркхолм"},
        {"Lacuna", "Лакуна"},
        {"Ozymandias", "Озимандиас"},
        {"Yoshi", "Йоши"},
        {"Smoogle", "Смоугл"},
        {"The Meowurer of Gods", "Мяукающий бог"},
        {"Outlaw", "Изгой"},
        {"Jade", "Джейд"},
        {"Nyavi Aceso", "Ньяви Ацесо"},
        {"Nyapano", "Няпано"},
        {"Kendra", "Кендра"},
        {"Bear", "Бир"},
        {"Felix", "Феликс"},
        {"Katsafaros", "Катсафарос"},
        {"Kiriku", "Кирику"},
        {"Morshu", "Моршу"},
        {"Captain Billy Bones", "Капитан Билли Бонс"},
        {"Slap Battles", "Слэп Баттлс"},
    };

    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void AI(NPC npc)
    {
        if (_townNpcNames.ContainsKey(npc.GivenName))
        {
            npc.GivenName = _townNpcNames[npc.GivenName];
        }
    }
}