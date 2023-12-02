using CalamityRuTranslate.Common.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace CalamityRuTranslate.Mods.Vanilla.MonoMod;

public class DrawBorderStringFourWayPatch : ILoadable
{
    public bool IsLoadingEnabled(Mod mod)
    {
        return TranslationHelper.IsRussianLanguage;
    }

    public void Load(Mod mod)
    {
        On_Utils.DrawBorderStringFourWay += On_UtilsOnDrawBorderStringFourWay;
    }

    public void Unload()
    {
        On_Utils.DrawBorderStringFourWay -= On_UtilsOnDrawBorderStringFourWay;
    }
    
    private void On_UtilsOnDrawBorderStringFourWay(On_Utils.orig_DrawBorderStringFourWay orig, SpriteBatch sb, DynamicSpriteFont font, string text, float x, float y, Color textcolor, Color bordercolor, Vector2 origin, float scale)
    {
        text = text switch
        {
            // Infernum
            "Thanatos, a serpentine terror with impervious armor and innumerable laser turrets." => "Танатос - змееподобный ужас с непробиваемой броней и бесчисленным количеством лазерных турелей.",
            "Ares, a heavyweight, diabolical monstrosity with six Exo superweapons." => "Арес - тяжеловес, дьявольское чудовище с шестью экзо-супероружиями.",
            "Artemis and Apollo, a pair of extremely agile destroyers with unstable energy reserves." => "Артемида и Аполлон - тандем чрезвычайно манёвренных уничтожителей, обладающих нестабильным запасом энергии.",
            _ => text
        };
        
        orig.Invoke(sb, font, text, x, y, textcolor, bordercolor, origin, scale);
    }
}