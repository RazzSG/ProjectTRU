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
    }

    public void Unload()
    {
        On_ChatManager.DrawColorCodedStringWithShadow_SpriteBatch_DynamicSpriteFont_string_Vector2_Color_float_Vector2_Vector2_float_float -= DrawColorCodedStringWithShadowHook;
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
        if (text.Contains("Сопротивление"))
        {
            text = text.Replace("Школы тайн", "Тайный");
            text = text.Replace("Школы огня", "Огонь");
            text = text.Replace("Школы воды", "Вода");
            text = text.Replace("Школы льда", "Лёд");
            text = text.Replace("Школы земли", "Земля");
            text = text.Replace("Школы воздуха", "Воздух");
            text = text.Replace("Школы молнии", "Молния");
            text = text.Replace("Школы святости", "Святость");
            text = text.Replace("Школы тени", "Тень");
            text = text.Replace("Школы природы", "Природа");
            text = text.Replace("Школы яда", "Яд");
            text = text.Replace("Школы крови", "Кровь");
            text = text.Replace("Школы менталистики", "Менталист");
            text = text.Replace("Школы космоса", "Космос");
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
}