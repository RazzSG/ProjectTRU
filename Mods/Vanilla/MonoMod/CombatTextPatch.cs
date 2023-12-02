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
            // "Blasting Form" => "Взрывная форма",
            // "Striking Form" => "Ударная форма",
            // "Fully charged!" => "",
            // "Blade Will activated!" => "",
            // "Mystic Form" => "",
            // "Scythe deployed!" => "",
            // "Shotgun deployed!" => "",
            // "Blade deployed!" => "",
            // "Stellar Prism acquired!" => "",
            // "Covered in red paint!" => "Вы покрыты красной краской!",
            // "Covered in blue paint!" => "Вы покрыты синей краской!",
            // "Prismatic Core acquired!" => "",
            // "Covered in yellow paint!" => "",
            // "The Eye of Euthymia has 10 seconds left!" => "",
            // "The Core of Flames has 5 seconds left!" => "До готовности ядра пламени осталось 5 секунд",
            // "Boiling Blood has 5 seconds left!" => "До готовности кипящей крови осталось 5 секунд",
            // "Liberation Blazing is ready to strike!" => "Пылающая освободительница готова к удару!",
            // "The Timeframe vanishes..." => "",
            // "Critical cast!" => "",
            // "Stellar Nova ready!" => "Астронова готова!",
            // "Dualcast!" => "Двойные чары!",
            // "Black Enchantment!" => "",
            // "White Enchantment!" => "",
            // Infernum
            "Peck!" => "Библиять!",
            // Thorium
            "ERADICATED" => "УНИЧТОЖЕН",
            "Close call" => "На волоске",
            "Freebie!" => "Даром!",
            "4999 life/5 sec" => "4999 здоровья/5 сек",
            "No Blood Chamber in world" => "В мире нет Кровавой камеры",
            "STRIKE" => "УДАР",
            _ => text
        };
        
        return orig.Invoke(location, color, text, dramatic, dot);
    }
}