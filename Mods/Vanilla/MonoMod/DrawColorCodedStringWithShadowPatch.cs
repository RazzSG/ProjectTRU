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
        
        return orig.Invoke(spritebatch, font, text, position, basecolor, rotation, origin, basescale, maxwidth, spread);
    }
}