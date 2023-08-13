﻿using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Vanilla.MonoMod;

public class DrawBorderStringFourWayPatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        On_Utils.DrawBorderStringFourWay += UtilsOnDrawBorderStringFourWay;
    }

    public void Unload()
    {
        On_Utils.DrawBorderStringFourWay -= UtilsOnDrawBorderStringFourWay;
    }
    
    private void UtilsOnDrawBorderStringFourWay(On_Utils.orig_DrawBorderStringFourWay orig, SpriteBatch sb, DynamicSpriteFont font, string text, float x, float y, Color textcolor, Color bordercolor, Vector2 origin, float scale)
    {
        text = text switch
        {
            // Calamity
            "Insufficient minion slots!" => "Недостаточно слотов призываемых миньонов!",
            _ => text
        };

        orig.Invoke(sb, font, text, x, y, textcolor, bordercolor, origin, scale);
    }

    
}