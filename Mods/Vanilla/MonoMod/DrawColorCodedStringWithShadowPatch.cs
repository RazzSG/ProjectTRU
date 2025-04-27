using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class DrawColorCodedStringWithShadowPatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        On_ChatManager.DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float += DrawColorCodedStringWithShadowHook;
        On_ChatManager.DrawColorCodedString_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_bool += On_ChatManagerOnDrawColorCodedString_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_bool;
    }

    public void Unload()
    {
        On_ChatManager.DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float -= DrawColorCodedStringWithShadowHook;
        On_ChatManager.DrawColorCodedString_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_bool -= On_ChatManagerOnDrawColorCodedString_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_bool;
    }

    private Vector2 DrawColorCodedStringWithShadowHook(On_ChatManager.orig_DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float orig, SpriteBatch spritebatch, DynamicSpriteFont font, string text, Vector2 position, Color basecolor, float rotation, Vector2 origin, Vector2 basescale, float maxwidth, float spread)
    {
        // Thorium
        if (text.Contains("[Unlocks in shop]"))
        {
            text = text.Replace("Unlocks in shop", "Открывается в магазине");
        }
        if (text.Contains("'s Gateway"))
        {
            // IL hook ломает логику
            text = text.Replace("'s Gateway", " - Врата");
        }
        
        // Redemption
        if (text.Contains("Сопротивление школам") || text.Contains("Урон школ"))
        {
            text = text.Replace("Школы тайн", "Школа тайн");
            text = text.Replace("Школы огня", "Школа огня");
            text = text.Replace("Школы воды", "Школа воды");
            text = text.Replace("Школы льда", "Школа льда");
            text = text.Replace("Школы земли", "Школа земли");
            text = text.Replace("Школы воздуха", "Школа воздуха");
            text = text.Replace("Школы молнии", "Школа молнии");
            text = text.Replace("Школы святости", "Школа святости");
            text = text.Replace("Школы тени", "Школа тени");
            text = text.Replace("Школы природы", "Школа природы");
            text = text.Replace("Школы яда", "Школа яда");
            text = text.Replace("Школы крови", "Школа крови");
            text = text.Replace("Школы псионики", "Школа псионики");
            text = text.Replace("Школы космоса", "Школа космоса");
        }
        
        text = text switch
        {
            // Thorium
            "Close" => "Закрыть",
            "Previous" => "Предыдущий",
            "Next" => "Следующий",
            _ => text
        };
        
        return orig.Invoke(spritebatch, font, text, position, basecolor, rotation, origin, basescale, maxwidth, spread);
    }
    
    private Vector2 On_ChatManagerOnDrawColorCodedString_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_bool(On_ChatManager.orig_DrawColorCodedString_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_bool orig, SpriteBatch spritebatch, DynamicSpriteFont font, string text, Vector2 position, Color basecolor, float rotation, Vector2 origin, Vector2 basescale, float maxwidth, bool ignorecolors)
    {
        text = text switch
        {
            // Wrath of the Gods
            "New!" => "Новая",
            _ => text
        };
        
        return orig.Invoke(spritebatch, font, text, position, basecolor, rotation, origin, basescale, maxwidth, ignorecolors);
    }
}