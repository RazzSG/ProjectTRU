using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class CombatTextPatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        On_CombatText.NewText_Rectangle_Color_string_bool_bool += On_CombatTextOnNewText_Rectangle_Color_string_bool_bool;
    }

    public void Unload()
    {
        On_CombatText.NewText_Rectangle_Color_string_bool_bool -= On_CombatTextOnNewText_Rectangle_Color_string_bool_bool;
    }
    
    private int On_CombatTextOnNewText_Rectangle_Color_string_bool_bool(On_CombatText.orig_NewText_Rectangle_Color_string_bool_bool orig, Rectangle location, Color color, string text, bool dramatic, bool dot)
    {
        string[] parts = text.Split(' ');
        var streak = parts[0];
        if (text == $"{streak} life heal streak")
        {
            if (int.TryParse(streak, out int value))
            {
                string suffix = LocalizedText.ApplyPluralization("{^0:единицы;единиц;единиц}", value);
                text = $"Серия из {value} {suffix} восстановленного здоровья";
            }
        }
        
        text = text switch
        {
            // Stars Above
            "Blasting Form" => "Взрывная форма",
            "Striking Form" => "Ударная форма",
            "Fully charged!" => "Полный заряд!",
            "Blade Will activated!" => "Воли клинка активирована!",
            "Mystic Form" => "Мистическая форма",
            "Stellar Prism acquired!" => "Получена звёздная призма!",
            "Prismatic Core acquired!" => "Получено призматическое ядро!",
            "The Eye of Euthymia has 10 seconds left!" => "До готовности глаза эвтюмии осталось 10 секунд!",
            "The Core of Flames has 5 seconds left!" => "До готовности сердца пламени осталось 5 секунд!",
            "Boiling Blood has 5 seconds left!" => "До готовности кипящей крови осталось 5 секунд!",
            "Liberation Blazing is ready to strike!" => "Огненная заря освобождения готова к удару!",
            "The Timeframe vanishes..." => "Временной скачок истекает...",
            "Critical cast!" => "Критический удар!",
            "Stellar Nova ready!" => "Астронова готова!",
            "Dualcast!" => "Двойные чары!",
            "Black Enchantment!" => "Чёрные чары!",
            "White Enchantment!" => "Белые чары!",
            // Infernum
            "Peck!" => "Библиять!",
            // Thorium
            "ERADICATED" => "УНИЧТОЖЕН",
            "Close call" => "На волоске",
            "Freebie!" => "Даром!",
            "4999 life/5 sec" => "4999 здоровья/5 сек",
            "No Blood Chamber in world" => "В мире нет Кровавой камеры",
            "STRIKE" => "УДАР",
            // Redemption
            // "Guard Broken!" => "Барьер сломан!",
            // "Decapitated!" => "Обезглавлен!",
            // "I'm sure you shouldn't have it in your inventory..." => "Уверен, этому не место в твоём инвентаре...",
            // "Oh, what a lovely ribbon you have over here." => "Ох, какая прелестная ленточка у тебя тут.",
            // "Xenium Staff op, please nerf." => "Ксениевый посох имба, просьба понерфить.",
            // "skill issue smh" => "skill issue, хех",
            // "Nothing happens..." => "Ничего не происходит...",
            // "No targets found!" => "Цель не найдена!",
            // "TARGET UNIMPORTANT..." => "ЦЕЛЬ НЕСУЩЕСТВЕННА...",
            // "INTRUDER DETECTED..." => "ОБНАРУЖЕН НАРУШИТЕЛЬ...",
            // "BOOM!" => "БУМ!",
            // "Hello!" => "Ау!",
            // "Listen!" => "Слушай!",
            // "Hey!" => "Эй!",
            // "soup?" => "Супчик?",
            // "yum yum" => "Вкуснятина",
            // "phish" => "Рибёха",
            // "fishy" => "Рибнотище",
            // "gimmi phish" => "Дай рибёху",
            // "feed me" => "Покорми меня",
            // "cookie" => "Печенька",
            // "gimmi cookie" => "Дай печеньку",
            // "*toot*" => "*Пук*",
            // "egg" => "Яичко",
            // "chikcen" => "Куреча",
            // "chkcien funni" => "Куреча смешная",
            // "i laugh at chieken" => "Куреча, ты меня уморила",
            // "gimmi chciken" => "Дай куречу",
            // "hello?" => "Ау?",
            // "where is hoomun?" => "Где челавек?",
            // "mamaa" => "Мама",
            // "where you at?" => "Ты где?",
            // "why you leave?" => "Зачем ты пропал?",
            // "yummy blood" => "Вкусная кровушка",
            // "you bleeding" => "У тебя кровь",
            // "blod" => "Кровушка",
            // "hurry up" => "Шевелись",
            // "you're too slow" => "Ну ты копуша",
            // "move move move" => "Шевелись, шевелись, шевелись",
            // "is it cold in there?" => "Холодненькой водички не хочешь?",
            // "i'll get you out!" => "Ща отогреем!",
            // "brrr" => "Дрож-ж-жачок!",
            // "that bite wasn't from me" => "Это не я укусил",
            // "*nom*" => "*хрум*",
            // "stinky" => "Вонючка",
            // "you stinky" => "Ты вонючка",
            // "uh oh stinky" => "Фу, вонючка",
            // "ew" => "Фу",
            // "Always watching..." => "Я слежу...",
            // "You got any pasta?" => "Макарошки не найдутся?",
            // "You think you're safe?" => "Думаешь, ты в безопасности?",
            // "Pitiful fool..." => "Жалкий глупец...",
            // "cheese" => "Чиииз",
            // "I have too much swagger for the dagger" => "Я слишком крут для кинжала",
            // "spooky" => "Страшно",
            // "Boo!" => "Бу!",
            // "Got a sauna?" => "Есть сауна?",
            // "spooky scary skeletons~" => "Жуткий, страшный скелетон~",
            // "noniin..." => "Ну вот...",
            // "My ladle knows no mercy." => "Мой половник не знает пощады.",
            // "Too dapper for the dagger" => "Слишком щеголеватый для кинжала",
            // "ded" => "Помер",
            // "Ka dosmok cul', ut yai hu roma," => "Ка досмок куль, ут яй ху рома,",
            // "Acett'nin jugh, il noka voe yu commu," => "Ацетт’нин джуг, ил нока вое ю комму,",
            // "Cult'nin un yei ruk', consu'nin yei min'," => "Культ’нин ун еи рук, консун’нин еи мин,",
            // "Ot I cun, jugh niqui tie." => "От и кун, джуг никуи ти.",
            _ => text
        };
        
        return orig.Invoke(location, color, text, dramatic, dot);
    }
}