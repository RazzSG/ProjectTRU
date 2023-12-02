using System;
using System.Reflection;
using CalamityMod;
using CalamityMod.Systems;
using CalamityMod.UI.ModeIndicator;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class ModeIndicatorUIPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ModeIndicatorUI).GetCachedMethod(nameof(ModeIndicatorUI.GetDifficultyStatus));

    private delegate void GetDifficultyStatusDelegate(out LocalizedText text);
    
    public override Delegate Delegate => Translation;

    private void Translation(GetDifficultyStatusDelegate orig, out LocalizedText text)
    {
        text = LocalizedText.Empty;
        
        if (ModeIndicatorUI.MouseScreenArea.Intersects(ModeIndicatorUI.MainClickArea))
        {
            string name = DifficultyModeSystem.Difficulties[1].Name.ToString();
            bool flag = false;
            for (int index = 1; index < DifficultyModeSystem.Difficulties.Count; ++index)
            {
                if (DifficultyModeSystem.GetCurrentDifficulty == DifficultyModeSystem.Difficulties[index])
                {
                    name = DifficultyModeSystem.Difficulties[index].Name.ToString();
                    flag = true;
                }
            }

            string textValue2 = name == "Инфернум"
                ? CalamityUtils.GetTextValue("UI." + (flag ? "InfernumActive" : "InfernumNotActive"))
                : CalamityUtils.GetTextValue("UI." + (flag ? "Active" : "NotActive"));
            
            text = CalamityUtils.GetText("UI.DifficultyStatusText").WithFormatArgs(name, textValue2.ToLower());
        }
    }
}