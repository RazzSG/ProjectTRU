using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ThoriumMod.UI.ResourceBars;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class InformationalIconsPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Thorium != null && TRuConfig.Instance.ThoriumModLocalization && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(InformationalIcons).FindMethod("DisplayIconNearEquips");

    public override Delegate Delegate { get; } = (Action<SpriteBatch, Texture2D, int, float, string, string, Vector2, string> orig, SpriteBatch spriteBatch, Texture2D tex, int yOffDefault, float yOffFactor, string iconText, string iconTextSuf, Vector2 iconTextOffset, string mouseText) =>
    {
        if (iconTextSuf.Contains("sec"))
            iconTextSuf = iconTextSuf.Replace("sec", "сек");
        
        orig.Invoke(spriteBatch, tex, yOffDefault, yOffFactor, iconText, iconTextSuf, iconTextOffset, mouseText);
    };
}