using System;
using System.Linq;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using PathOfTerraria.Common.Waypoints.UI;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace CalamityRuTranslate.Mods.PathOfTerraria.MonoMod;

public class UIWaypointMenuPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(UIWaypointMenu).FindMethod(nameof(UIWaypointMenu.Update));

    public override Delegate Delegate => Translation;
    
    private void Translation(Action<UIWaypointMenu, GameTime> orig, UIWaypointMenu self, GameTime gameTime)
    {
        orig.Invoke(self, gameTime);

        UIElement listRootElement = self.GetMemberValue<UIElement>("listRootElement");
        UIText waypoints = listRootElement.Children.OfType<UIText>().FirstOrDefault(t => t.Text == "Waypoints");
        UIScalingText buttonText = self.GetMemberValue<UIScalingText>("buttonText");
        
        waypoints?.SetText("Путевые точки");
        buttonText.SetText("Путешествовать");
    }
}