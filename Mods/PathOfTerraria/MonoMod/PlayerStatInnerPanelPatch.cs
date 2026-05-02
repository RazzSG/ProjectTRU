using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.PathOfTerraria.MonoMod;

public class UpdatePatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.PathOfTerraria.Code.GetType("PathOfTerraria.Common.UI.PlayerStats.PlayerStatInnerPanel+PlayerStatUI").FindMethod("Update");

    public override Delegate Delegate => Translation;
    
    private void Translation(Action<object, GameTime> orig, object self, GameTime gameTime)
    {
        orig(self, gameTime);

        if (self is UIText uiText)
        {
            string currentText = uiText.Text;
            
            if (!string.IsNullOrEmpty(currentText) && currentText.Contains("s"))
            {
                uiText.SetText(currentText.Replace("s", " сек"));
            }
        }
    }
}

public class PlayerStatInnerPanelPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodBase ModifiedMethod => ModInstances.PathOfTerraria.Code.GetType("PathOfTerraria.Common.UI.PlayerStats.PlayerStatInnerPanel+PlayerStatUI").FindConstructor(typeof(LocalizedText), typeof(Func<Player, string>), typeof(float), typeof(bool), typeof(bool), typeof(LocalizedText), typeof(bool));
    
    public override Delegate Delegate => Translation;

    private void Translation(Action<object, LocalizedText, Func<Player, string>, float, bool, bool, LocalizedText, bool> orig, object self, LocalizedText text, Func<Player, string> getValue, float scale, bool big, bool noColon, LocalizedText hover, bool isHeader)
    {
        if (scale == 1f)
            scale = 0.85f;

        orig(self, text, getValue, scale, big, noColon, hover, isHeader);
    }
}