using System;
using System.Linq;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Content.UI;
using Microsoft.Xna.Framework;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod;

public class ActiveSkillMenuPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.FargowiltasSouls != null && TRuConfig.Instance.FargowiltasSoulsLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(ActiveSkillMenu).FindMethod(nameof(ActiveSkillMenu.Update));

    public override Delegate Delegate => (Action<ActiveSkillMenu, GameTime> orig, ActiveSkillMenu self, GameTime gameTime) =>
    {
        orig.Invoke(self, gameTime);
        
        UIText oldActiveSkills = self.BackPanel.Children.OfType<UIText>().FirstOrDefault(t => t.Text == Language.GetTextValue("Mods.FargowiltasSouls.UI.ActiveSkills"));
        UIText oldAvailableSkills = self.BackPanel.Children.OfType<UIText>().FirstOrDefault(t => t.Text == Language.GetTextValue("Mods.FargowiltasSouls.UI.AvailableSkills"));
        
        self.BackPanel.RemoveChild(oldActiveSkills);
        self.BackPanel.RemoveChild(oldAvailableSkills);
        
        UIText newActiveSkills = new UIText(Language.GetTextValue("Mods.FargowiltasSouls.UI.ActiveSkills"))
        {
            HAlign = 0.5f,
            Top = StyleDimension.FromPixels(6f)
        };
        UIText newAvailableSkills = new UIText(Language.GetTextValue("Mods.FargowiltasSouls.UI.AvailableSkills"))
        {
            HAlign = 0.5f,
            Top = StyleDimension.FromPixels(self.AvailablePanel.Top.Pixels + 5f)
        };
        
        self.BackPanel.Append(newActiveSkills);
        self.BackPanel.Append(newAvailableSkills);
    };
}