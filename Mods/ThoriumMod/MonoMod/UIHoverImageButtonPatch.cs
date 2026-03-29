using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.UI;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class UIHoverImageButtonPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Thorium != null && TRuConfig.Instance.ThoriumModLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => ModInstances.Thorium.Code.GetType("ThoriumMod.UI.UIHoverImageButton")?.FindMethod("DrawSelf");

    public override Delegate Delegate => Translation;
    
    private void Translation(Action<object, SpriteBatch> orig, object self, SpriteBatch spriteBatch)
    {
        orig.Invoke(self, spriteBatch);
        
        if (self is UIElement {IsMouseHovering: true})
        {
            Main.hoverItemName = Main.hoverItemName switch
            {
                "Close" => "Закрыть",
                "Previous" => "Предыдущий",
                "Next" => "Следующий",
                _ => Main.hoverItemName
            };
        }
    }
}