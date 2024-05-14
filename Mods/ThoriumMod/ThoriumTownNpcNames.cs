using System.Collections.Generic;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using Terraria;
using Terraria.ModLoader;
using ThoriumMod.NPCs;

namespace CalamityRuTranslate.Mods.ThoriumMod;

public class ThoriumTownNpcNames : GlobalNPC
{
    private static Dictionary<int, List<string>> _townNpcNames = new()
    {
        { ModContent.NPCType<Blacksmith>(),
            [
                "Альберт", "Брутус", "Байрон", "Клей", "Дуэйн", "Флинт", "Джордж", "Грегори", "Хаган", "Ханс", "Хедрик",
                "Килбас", "Лестер", "Мейсон", "Макдуфф", "Пол", "Смит", "Трактирщик", "Виктор", "Вейланд"
            ]
        },
        { ModContent.NPCType<Cobbler>(),
            [
                "Альфред", "Альфонс", "Барни", "Бакстер", "Калвин", "Кертис", "Десмонд", "Димитрий", "Фред",
                "Грисвальд",  "Айк", "Джонатан", "Кеннет", "Ларри", "Лоуренс", "Луис", "Квинн", "Стэнли", "Уинстон", "Уайатт"
            ]
        },
        { ModContent.NPCType<ConfusedZombie>(),
            [
                "Байл", "Блоат", "Каррион", "Дедбит", "Фестер", "Гасбэг", "Гримм", "Гранди", "Лазарус", "Лич", "Морт",
                "Олли", "Пустула", "Рихтер", "Ротгут", "Салем", "Ститч", "Вернон", "Виктор", "Яйкс"
            ]
        },
        { ModContent.NPCType<Cook>(),
            [
                "Ален", "Алексис", "Альфредо", "Алтон", "Антуан", "Огюст", "Эмерил", "Эрик", "Фернанд", "Флей",
                "Гордон", "Гийом", "Гай", "Жак", "Джейми", "Джоэл", "Лингуини", "Филипп", "Томас", "Вольфганг"
            ]
        },
        { ModContent.NPCType<DesertAcolyte>(),
            [
                "Ахмад", "Ахура", "Аладдин", "Ба'кий Кум", "Банумуса", "Бируни", "Гаршасп", "Гази", "Джордан", "Кинди",
                "Хваризми", "Курош", "Мааз", "Маздак", "Мардук", "Пурья", "Сахир", "Сассан", "Язата", "Зерзура"
            ]
        },
        { ModContent.NPCType<Diverman>(),
            [
                "Адин", "Александр", "Остин", "Калдер", "Камерон", "Карлос", "Клайд", "Илия", "Итан", "Фрэнсис",
                "Джесси", "Максвелл", "Нил", "Нолен", "Перси", "Роберт", "Родригес", "Сэм", "Стивен", "Зейн"
            ]
        },
        { ModContent.NPCType<Druid>(),
            [
                "Алисса", "Камелия", "Церера", "Черил", "Кловер", "Эрика", "Флёр", "Фолиум", "Форсития", "Хана",
                "Линья", "Лигнум", "Лайлак", "Лилли", "Магнолия", "Примроз", "Роза", "Виридис", "Ярров", "Зинния"
            ]
        },
        { ModContent.NPCType<Spiritualist>(),
            [
                "Алгалон", "Бальтазар", "Боди", "Каспар", "Дхрув", "Дуайт", "Диеус", "Кетер", "Малкут", "Мельхиор",
                "Никс", "Ормазд", "Пакс", "Пси", "Соломон", "Титус", "Янг", "Язата", "Йин", "Зен"
            ]
        },
        { ModContent.NPCType<Tracker>(),
            [
                "Аарон", "Атлас", "Бернард", "Брендан", "Клифтон", "Конрад", "Сайрис", "Далтон", "Дастон", "Деррик",
                "Гарм", "Густав", "Гатс", "Хантер", "Кван", "Линус", "Рой", "Рассел", "Шнайдер", "Тристан"
            ]
        },
        { ModContent.NPCType<WeaponMaster>(),
            [
                "Брузо", "Краторберст", "Флатум", "Фузгром", "Глиб'ток", "Гно'кэр", "Грет'зек", "Хатгор", "Хатлос",
                "Хельнос", "Хиндаракс", "Хро'грак", "Кадрон", "Контаст", "Меззнар", "Морголон", "Моррик", "Сера'нот",
                "Таргуп", "Вилот"
            ]
        },
    };
    
    public override bool IsLoadingEnabled(Mod mod)
    {
        return ModInstances.Thorium != null && TranslationHelper.IsRussianLanguage;
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