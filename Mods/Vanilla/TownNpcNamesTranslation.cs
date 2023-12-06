using System.Collections.Generic;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla;

public class TownNpcNamesTranslation : GlobalNPC
{
    private readonly Dictionary<int, Dictionary<string, string>> _townNpcNames = new()
    {
        [NPCID.Angler] = new Dictionary<string, string>
        {
            {"Dazren", "Дазрен"},
            {"Johnny Test", "Джонни Тест"},
        },
        [NPCID.ArmsDealer] = new Dictionary<string, string>
        {
            {"Dazren", "Дазрен"},
            {"Drifter", "Дрифтер"},
            {"Finchi", "Финчи"},
            {"Heniek", "Хеник"},
            {"Fire", "Фаер"},
            {"Barney Calhoun", "Барни Калхаун"},
            {"XiaoEn0426", "СяоЭн0426"},
            {"Jeffred", "Джеффред"},
            {"The Cooler Arthur", "Крутой Артур"},
            {"Markie", "Марки"},
        },
        [NPCID.Clothier] = new Dictionary<string, string>
        {
            {"Joeseph Jostar", "Джозеф Джостар"},
            {"Storm Havik", "Шторм Хавик"},
        },
        [NPCID.Cyborg] = new Dictionary<string, string>
        {
            {"Sylux", "Силикс"},
        },
        [NPCID.Demolitionist] = new Dictionary<string, string>
        {
            {"Tavish DeGroot", "Тавиш ДеГрут"},
        },
        [NPCID.Dryad] = new Dictionary<string, string>
        {
            {"Rythmi", "Ритми"},
            {"Izuna", "Изуна"},
            {"Jasmine", "Жасмин"},
            {"Cybil", "Сибил"},
            {"Ruth", "Рут"},
        },
        [NPCID.GoblinTinkerer] = new Dictionary<string, string>
        {
            {"Verth", "Верт"},
            {"Gormer", "Кормер"},
            {"TingFlarg", "ТингФларг"},
            {"Driser", "Драйзер"},
            {"Eddie Spaghetti", "Эдди Спагетти"},
            {"G'tok", "Г'ток"},
            {"Katto", "Катто"},
            {"Him", "Хим"},
            {"Tooshiboots", "Тушибутс"},
            {"Neesh", "Ниш"},
        },
        [NPCID.Guide] = new Dictionary<string, string>
        {
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
            {"Grylken", "Грилькен"},
            {"Outlaw", "Изгой"},
            {"Alfred Rend", "Альфред Ренд"},
            {"Leeman", "Лиман"},
            {"Mihai", "Михай"},
            {"Aka Retribution", "Ака Возмездие"},
        },
        [NPCID.Mechanic] = new Dictionary<string, string>
        {
            {"Lilly", "Лилли"},
            {"Daawn", "Даан"},
            {"Robin", "Робин"},
            {"Curly", "Кудряшка"},
        },
        [NPCID.Merchant] = new Dictionary<string, string>
        {
            {"Morshu", "Моршу"},
        },
        [NPCID.Nurse] = new Dictionary<string, string>
        {
            {"Farsni", "Фарсни"},
            {"Fanny", "Фанни"},
            {"Mausi", "Мауси"},
        },
        [NPCID.Painter] = new Dictionary<string, string>
        {
            {"Picasso", "Пикассо"},
        },
        [NPCID.PartyGirl] = new Dictionary<string, string>
        {
            {"Arin", "Арин"},
        },
        [NPCID.Pirate] = new Dictionary<string, string>
        {
            {"Tyler Van Hook", "Тайлер Ван Хук"},
            {"Cap'n Deek", "Кэп'н Дик"},
            {"Captain Billy Bones", "Капитан Билли Бонс"},
            {"Captain J. Crackers", " Капитан Дж. Крэкерс"},
        },
        [NPCID.Princess] = new Dictionary<string, string>
        {
            {"Catalyst", "Каталист"},
            {"Nyapano", "Няпано"},
            {"Jade", "Джейд"},
            {"Nyavi Aceso", "Ньяви Ацесо"},
            {"everquartz", "Эверкварц"},
            {"Gwynevere", "Гвиневер"},
        },
        [NPCID.SantaClaus] = new Dictionary<string, string>
        {
            {"Jank", "Джанк"},
        },
        [NPCID.SkeletonMerchant] = new Dictionary<string, string>
        {
            {"Sans Undertale", "Санс Андертейлов"},
            {"Papyrus Undertale", "Папирус Андертейлов"},
            {"Mr. Bones", "Мистер Бонс"},
        },
        [NPCID.Steampunker] = new Dictionary<string, string>
        {
            {"Vorbis", "Ворбис"},
            {"Angel", "Энжел"},
        },
        [NPCID.Stylist] = new Dictionary<string, string>
        {
            {"Amber", "Эмбер"},
            {"Faith", "Фейт"},
            {"Xsiana", "Ксиана"},
        },
        [NPCID.DD2Bartender] = new Dictionary<string, string>
        {
            {"Tim Lockwood", "Тим Локвуд"},
            {"Sir Samuel Winchester Jenkins Kester II", "Сэр Сэмюэль Винчестер Дженкинс Кестер II"},
            {"Brutus", "Брутус"},
            {"Sloth", "Слот"},
        },
        [NPCID.TaxCollector] = new Dictionary<string, string>
        {
            {"Emmett", "Эммет"},
        },
        [NPCID.TravellingMerchant] = new Dictionary<string, string>
        {
            {"Stan Pines", "Стэн Пайнс"},
            {"Slap Battles", "Слэп Баттлс"},
        },
        [NPCID.Truffle] = new Dictionary<string, string>
        {
            {"Aldrimil", "Альдримил"},
        },
        [NPCID.WitchDoctor] = new Dictionary<string, string>
        {
            {"Sok'ar", "Сокар"},
            {"Toxin", "Токсин"},
            {"Mixcoatl", "Мишкоатль"},
            {"Khatunz", "Хатунц"},
            {"Amnesia Wapers", "Амнезия Вейперс"},
        },
        [NPCID.Wizard] = new Dictionary<string, string>
        {
            {"Mage One-Trick", "Маг Трюкач"},
            {"Inorim, son of Ivukey", "Инорим, сын Ивукея"},
            {"Jensen", "Дженсен"},
            {"Merasmus", "Мерасмус"},
            {"Habolo", "Хаболо"},
            {"Ortho", "Орто"},
            {"Chris Tallballs", "Шаркрис Тальный"},
            {"Syethas", "Ситас"},
            {"Nextdoor Psycho", "Шизак Даркхолм"},
        },
        [NPCID.BestiaryGirl] = new Dictionary<string, string>
        {
            {"Kiriku", "Кирику"},
            {"Lacuna", "Лакуна"},
            {"Mae Borowski", "Мэй Боровски"},
        },
        [NPCID.TownDog] = new Dictionary<string, string>
        {
            {"Ozymandias", "Озимандиас"},
            {"Kendra", "Кендра"},
            {"Yoshi", "Йоши"},
            {"Riley", "Райли"},
            {"Splinter", "Сплинтер"},
        },
        [NPCID.TownCat] = new Dictionary<string, string>
        {
            {"Smoogle", "Смоугл"},
            {"The Meowurer of Gods", "Мяукающий бог"},
            {"Katsafaros", "Катсафарос"},
            {"Bear", "Миша"},
            {"Felix", "Феликс"},
            {"Lucerne", "Люцерн"},
            {"Milo", "Мило"},
            {"Octo", "Окто"},
        },
        // [NPCID.TownBunny] = new Dictionary<string, string>
        // {
        // },
    };

    public override bool InstancePerEntity => true;
    
    public override bool AppliesToEntity(NPC entity, bool lateInstantiation)
    {
        return entity.townNPC || entity.type == NPCID.SkeletonMerchant;
    }
    
    public override bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public override void ModifyNPCNameList(NPC npc, List<string> nameList)
    {
        if (_townNpcNames.TryGetValue(npc.type, out var names))
        {
            for (int i = 0; i < nameList.Count; i++)
            {
                if (names.TryGetValue(nameList[i], out var name))
                {
                    nameList[i] = name;
                }
            }
        }
    }
}