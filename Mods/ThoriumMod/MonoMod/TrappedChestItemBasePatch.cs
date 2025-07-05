using System;
using System.Reflection;
using System.Text.RegularExpressions;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Terraria.Localization;
using ThoriumMod.Items;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class TrappedChestItemBasePatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Thorium != null && TRuConfig.Instance.ThoriumModLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(TrappedChestItemBase).FindMethod("get_DisplayName");
    
    public override Delegate Delegate => Translation;

    private LocalizedText Translation(Func<TrappedChestItemBase, LocalizedText> orig, TrappedChestItemBase self)
    {
        string chestName = self.ChestItem.DisplayName.Value;
        string newName;
        
        if (chestName.Contains("Сундук"))
        {
            Regex regex = new Regex("Сундук");
            newName = regex.Replace(chestName, "Сундук-ловушка", 1);
        }
        else
        {
            newName = $"{chestName}-ловушка";
        }
        
        return Language.GetOrRegister("Mods.ThoriumMod.Items." + self.Name, () => newName);
    }
}