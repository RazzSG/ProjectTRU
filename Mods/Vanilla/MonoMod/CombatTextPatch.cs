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
            // "Guard Broken!" => "",
            // "Decapitated!" => "",
            // "I'm sure you shouldn't have it in your inventory..." => "",
            // "Oh, what a lovely ribbon you have over here." => "",
            // "Xenium Staff op, please nerf." => "",
            // "skill issue smh" => "",
            // "Nothing happens..." => "",
            // "No targets found!" => "",
            // "TARGET UNIMPORTANT..." => "",
            // "INTRUDER DETECTED..." => "",
            // "BOOM!" => "",
            // "Hello!" => "",
            // "Listen!" => "",
            // "Hey!" => "",
            // "soup?" => "",
            // "yum yum" => "",
            // "phish" => "",
            // "fishy" => "",
            // "gimmi phish" => "",
            // "feed me" => "",
            // "cookie" => "",
            // "gimmi cookie" => "",
            // "*toot*" => "",
            // "egg" => "",
            // "chikcen" => "",
            // "chkcien funni" => "",
            // "i laugh at chieken" => "",
            // "gimmi chciken" => "",
            // "hello?" => "",
            // "where is hoomun?" => "",
            // "mamaa" => "",
            // "where you at?" => "",
            // "why you leave?" => "",
            // "yummy blood" => "",
            // "you bleeding" => "",
            // "blod" => "",
            // "hurry up" => "",
            // "you're too slow" => "",
            // "move move move" => "",
            // "is it cold in there?" => "",
            // "i'll get you out!" => "",
            // "brrr" => "",
            // "that bite wasn't from me" => "",
            // "*nom*" => "",
            // "stinky" => "",
            // "you stinky" => "",
            // "uh oh stinky" => "",
            // "ew" => "",
            // "Always watching..." => "",
            // "You got any pasta?" => "",
            // "You think you're safe?" => "",
            // "Pitiful fool..." => "",
            // "cheese" => "",
            // "I have too much swagger for the dagger" => "",
            // "spooky" => "",
            // "Boo!" => "",
            // "Got a sauna?" => "",
            // "spooky scary skeletons~" => "",
            // "noniin..." => "",
            // "My ladle knows no mercy." => "",
            // "Too dapper for the dagger" => "",
            // "ded" => "",
            _ => text
        };
        
        return orig.Invoke(location, color, text, dramatic, dot);
    }
}