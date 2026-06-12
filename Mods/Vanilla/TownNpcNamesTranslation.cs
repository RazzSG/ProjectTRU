using System.Collections.Generic;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla;

public class TownNpcNamesTranslation : GlobalNPC
{
    private static readonly Dictionary<int, Dictionary<string, string>> _townNpcNames = new()
    {
        [NPCID.Angler] = new Dictionary<string, string>
        {
            {"Dazren", "Дазрен"},
            {"Johnny Test", "Джонни Тест"},
            {"Bling Bling Boy", "Мальчик-показушник"},
            {"RICE", "РИЗ"},
            {"Quest Boy", "Квест-бой"},
        },
        [NPCID.ArmsDealer] = new Dictionary<string, string>
        {
            {"Finchi", "Финчи"},
            {"Heniek", "Хеник"},
            {"Fire", "Фаер"},
            {"Barney Calhoun", "Барни Калхаун"},
            {"XiaoEn0426", "СяоЭн0426"},
            {"Jeffred", "Джеффред"},
            {"The Cooler Arthur", "Крутой Артур"},
            {"Shark", "Шарк"},
            {"Sagi", "Саги"},
        },
        [NPCID.Clothier] = new Dictionary<string, string>
        {
            {"Joeseph Jostar", "Джозеф Джостар"},
            {"Storm Havik", "Шторм Хавик"},
            {"Magorfis Splunt the Greater Finklejim", "Магорфис Сплант, Великий Финкльджим"},
            {"Perrin", "Перрин"},
            {"Spud McGee", "Картофан Макги"},
        },
        [NPCID.Cyborg] = new Dictionary<string, string>
        {
            {"Sylux", "Силикс"},
            {"Nemesis", "Немезис"},
            {"Univerze", "Юниверз"},
            {"Hunk", "Амбал"},
        },
        [NPCID.Demolitionist] = new Dictionary<string, string>
        {
            {"Tavish DeGroot", "Тавиш ДеГрут"},
            {"Fimmy", "Фимми"},
            {"John Helldiver", "Джон Хеллдайвер"},
        },
        [NPCID.Dryad] = new Dictionary<string, string>
        {
            {"Rythmi", "Ритми"},
            {"Izuna", "Изуна"},
            {"Jasmine", "Жасмин"},
            {"Cybil", "Сибил"},
            {"Ruth", "Рут"},
            {"Kanna", "Канна"},
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
            {"Bars Boldia", "Барс Болдия"},
            {"Basel Raiden John Clive Fantasy 16", "Базель Райден Джон Клайв Фэнтези 16"},
            {"Gobby, Destroyer of Wallets", "Гобби, Разоритель кошельков"},
            {"Potential Man", "Человек-потенциал"},
            {"Donny G", "Донни Джи"},
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
            {"Dinkleberg", "Динклберг"},
            {"Wamy", "Уами"},
            {"Baggute", "Баггут"},
            {"Jacob Bryson", "Джейкоб Брайсон"},
            {"ImaShoe", "Я-Башмак"},
        },
        [NPCID.Mechanic] = new Dictionary<string, string>
        {
            {"Lilly", "Лилли"},
            {"Daawn", "Даан"},
            {"Robin", "Робин"},
            {"Curly", "Кудряшка"},
            {"Cobalt", "Лазурка"},
            {"Dizzetriya", "Диззетрия"},
            {"Vodka", "Водка"},
        },
        [NPCID.Merchant] = new Dictionary<string, string>
        {
            {"Morshu", "Моршу"},
            {"Spamton G. Spamton", "Спэмтон Дж. Спэмтон"},
            {"Goldluna", "Голдлуна"},
        },
        [NPCID.Nurse] = new Dictionary<string, string>
        {
            {"Farsni", "Фарсни"},
            {"Fanny", "Фанни"},
            {"Mausi", "Мауси"},
            {"Fiona", "Фиона"},
            {"Tikoh", "Тико"},
            {"Vivienne", "Вивьен"},
        },
        [NPCID.Painter] = new Dictionary<string, string>
        {
            {"Picasso", "Пикассо"},
            {"Bew", "Бью"},
        },
        [NPCID.PartyGirl] = new Dictionary<string, string>
        {
            {"Arin", "Арин"},
            {"Typhäne", "Тифен"},
            {"Charlotte Linlin", "Шарлотта Линлин"},
            {"Shmizzle Dizzle", "Шмиззл-Диззл"},
        },
        [NPCID.Pirate] = new Dictionary<string, string>
        {
            {"Tyler Van Hook", "Тайлер Ван Хук"},
            {"Cap'n Deek", "Кэп'н Дик"},
            {"Captain Billy Bones", "Капитан Билли Бонс"},
            {"Captain J. Crackers", "Капитан Дж. Крэкерс"},
            {"Gol D. Roger", "Гол Д. Роджер"},
            {"Yarrim", "Яррим"},
            {"Hector Barbossa", "Гектор Барбосса"},
            {"Blunderbeard", "Промахобород"},
            {"Vergil Cyrus", "Вергилий Сайрус"},
        },
        [NPCID.Princess] = new Dictionary<string, string>
        {
            {"Nyapano", "Няпано"},
            {"Jade", "Джейд"},
            {"Nyavi Aceso", "Ньяви Ацесо"},
            {"everquartz", "Эверкварц"},
            {"Gwynevere", "Гвиневер"},
            {"Hael", "Хэйл"},
            {"Yumesaki Mirrin", "Юмэсаки Миррин"},
            {"Vela", "Вела"},
            {"Misako Drevis", "Мисако Дрэвис"},
        },
        [NPCID.SantaClaus] = new Dictionary<string, string>
        {
            {"Jank", "Джанк"},
            {"Aoi Kurashiki", "Аой Курасики"},
        },
        [NPCID.SkeletonMerchant] = new Dictionary<string, string>
        {
            {"Sans Undertale", "Санс Андертейлов"},
            {"Papyrus Undertale", "Папирус Андертейлов"},
            {"Gaster Undertale", "Гастер Андертейлов"},
            {"Mr. Bones", "Мистер Бонс"},
            {"Freakbob", "Фрикбоб"},
            {"Bone Cold Steve Austin", "Ледяная Кость Стив Остин"},
            {"Them Bones", "Наника"},
            {"Deep-Vein Thrombonesis", "Тромбонез"},
        },
        [NPCID.Steampunker] = new Dictionary<string, string>
        {
            {"Vorbis", "Ворбис"},
            {"Angel", "Энжел"},
            {"Mòrag Ladair", "Мораг Лейдер"},
            {"Linn", "Линн"},
            {"Eira", "Ейра"},
            {"Kreutz", "Кройц"},
            {"Cathlyn", "Кэтлин"},
            {"Eunice", "Юнис"},
            {"Zera", "Зера"},
        },
        [NPCID.Stylist] = new Dictionary<string, string>
        {
            {"Amber", "Эмбер"},
            {"Faith", "Фейт"},
            {"Xsiana", "Ксиана"},
            {"Lain", "Лэйн"},
            {"Brio Scarlet", "Брио Скарлет"},
            {"Vanessa", "Ванесса"},
            {"Melanie", "Мелани"},
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
            {"Bagman", "Бэгмен"},
            {"Casino King Gray", "Казино Кинг Грей"},
            {"Old Man Scrooge", "Старик Скрудж"},
            {"Jerry Atric", "Джерри Атрик"},
            {"22 Platinum Coin Guy", "Парень с 22 платиновыми монетами"},
        },
        [NPCID.TravellingMerchant] = new Dictionary<string, string>
        {
            {"Stan Pines", "Стэн Пайнс"},
            {"Intergaze", "Интергейз"},
            {"Borgus", "Боргус"},
            {"Postman Hiss", "Почтальон Хисс"},
            {"Cosmoec", "Космоэк"},
            {"Junorism", "Джуноризм"},
            {"Koral", "Корал"},
            {"Phantom", "Фантом"},
        },
        [NPCID.Truffle] = new Dictionary<string, string>
        {
            {"Aldrimil", "Альдримил"},
            {"Wonton", "Вонтон"},
            {"Mad Lad", "Безумный малый"},
        },
        [NPCID.WitchDoctor] = new Dictionary<string, string>
        {
            {"Sok'ar", "Сокар"},
            {"Aeroni", "Аэрони"},
            {"Mixcoatl", "Мишкоатль"},
            {"Amnesia Wapers", "Амнезия Вейперс"},
            {"Tequila", "Текила"},
            {"Which Doctor", "Доктор Какой"},
            {"Bee Movie Script", "Би Муви"},
        },
        [NPCID.Wizard] = new Dictionary<string, string>
        {
            {"Inorim, son of Ivukey", "Инорим, сын Ивукея"},
            {"Jensen", "Дженсен"},
            {"Merasmus", "Мерасмус"},
            {"Habolo", "Хаболо"},
            {"Ortho", "Орто"},
            {"Chris Tallballs", "Шаркрис Тальный"},
            {"Syethas", "Ситас"},
            {"Nextdoor Psycho", "Шизак Даркхолм"},
            {"Mike Cyclops", "Майк Циклоп"},
            {"Derin", "Дерин"},
            {"Umbara", "Умбара"},
            {"Reyloth Grey", "Рейлот Грей"},
        },
        [NPCID.BestiaryGirl] = new Dictionary<string, string>
        {
            {"Kiriku", "Кирику"},
            {"Lacuna", "Лакуна"},
            {"Mae Borowski", "Мэй Боровски"},
            {"Fera", "Фира"},
            {"Gwenhwyvar", "Гвенхивар"},
            {"Daxie", "Дакси"},
            {"Zora", "Зора"},
            {"Summer", "Саммер"},
            {"Foxy", "Фокси"},
        },
        [NPCID.TownDog] = new Dictionary<string, string>
        {
            {"Ozymandias", "Озимандиас"},
            {"Miss Throws a Lot", "Мисс Метальщица"},
            {"Brikwilla", "Бриквилла"},
            {"Melody", "Мелоди"},
            {"Kendra", "Кендра"},
            {"Yoshi", "Йоши"},
            {"Riley", "Райли"},
            {"Splinter", "Сплинтер"},
            {"Mack", "Мак"},
            {"Libby", "Либи"},
            {"Myles", "Майлс"},
            {"Luna", "Луна"},
            {"Franklin", "Франклин"},
            {"Rocco", "Рокко"},
            {"Silvie", "Сильви"},
            {"Madison", "Мэдисон"},
        },
        [NPCID.TownCat] = new Dictionary<string, string>
        {
            {"Smoogle", "Смоугл"},
            {"The Meowurer of Gods", "Мяукающий бог"},
            {"Katsafaros", "Катсафарос"},
            {"Bear", "Миша"},
            {"Storm", "Шторм"},
            {"Hognar the Wicked", "Хогнар Нечестивый"},
            {"Felix", "Феликс"},
            {"Tardo", "Тардо"},
            {"Lucerne", "Люцерн"},
            {"Milo", "Мило"},
            {"Octo", "Окто"},
            {"Kreska", "Креска"},
            {"Archie", "Арчи"},
            {"Dali", "Дали"},
            {"Kiba", "Киба"},
            {"Conductor", "Кондуктор"},
            {"Vivian", "Вивиан"},
            {"Pudum", "Пудум"},
            {"Snickers", "Сникерс"},
            {"Mr. Kitten", "Мистер Котёнок"},
            {"Saffie", "Саффи"},
            {"Willow", "Уиллоу"},
            {"Maine", "Мэн"},
            {"Monkey", "Манки"},
            {"Percy", "Перси"},
            {"Pluey", "Плюи"},
            {"Meokei", "Меокей"},
        },
        [NPCID.TownBunny] = new Dictionary<string, string>
        {
            {"Poco", "Поко"},
            {"Puffer", "Пуффер"},
        },
        [NPCID.TownSlimeBlue] = new Dictionary<string, string>
        {
            {"Big Blungus", "Большой Блунгус"},
            {"Rimuru Tempest", "Римуру Темпест"},
        },
        [NPCID.TownSlimeRainbow] = new Dictionary<string, string>
        {
            {"Rise Kujikawa", "Рисэ Кудзикава"},
        },
    };
    
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
        if (_townNpcNames.TryGetValue(npc.type, out Dictionary<string, string> names))
        {
            for (int i = 0; i < nameList.Count; i++)
            {
                if (names.TryGetValue(nameList[i], out string name))
                {
                    nameList[i] = name;
                }
            }
        }
    }
}