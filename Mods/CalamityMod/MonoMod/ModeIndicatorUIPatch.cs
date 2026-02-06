using System;
using System.Reflection;
using CalamityMod;
using CalamityMod.Systems;
using CalamityMod.UI.ModeIndicator;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Terraria;
using Terraria.Localization;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class ModeIndicatorUIPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ModeIndicatorUI).FindMethod(nameof(ModeIndicatorUI.GetDifficultyStatus));

    private delegate void GetDifficultyStatusDelegate(out LocalizedText text);
    
    public override Delegate Delegate => Translation;

    private void Translation(GetDifficultyStatusDelegate orig, out LocalizedText text)
    {
        text = LocalizedText.Empty;
        
        if (ModeIndicatorUI.MouseScreenArea.Intersects(ModeIndicatorUI.MainClickArea))
        {
            string name = !Main.getGoodWorld || DifficultyModeSystem.Difficulties[0].FTWName == null
                ? DifficultyModeSystem.Difficulties[1].Name.ToString()
                : DifficultyModeSystem.Difficulties[0].FTWName.ToString();
            bool flag = Main.getGoodWorld;
            for (int index = 1; index < DifficultyModeSystem.Difficulties.Count; ++index)
            {
                if (DifficultyModeSystem.GetCurrentDifficulty == DifficultyModeSystem.Difficulties[index])
                {
                    name = !Main.getGoodWorld || DifficultyModeSystem.Difficulties[index].FTWName == null
                        ? DifficultyModeSystem.Difficulties[index].Name.ToString()
                        : DifficultyModeSystem.Difficulties[index].FTWName.ToString();
                    flag = true;
                }
            }

            string textValue2 = name is "Инфернум" or "Эксперт" or "Мастер"
                ? CalamityUtils.GetTextValue("UI." + (flag ? "InfernumActive" : "InfernumNotActive"))
                : CalamityUtils.GetTextValue("UI." + (flag ? "Active" : "NotActive"));
            
            text = CalamityUtils.GetText("UI.DifficultyStatusText").WithFormatArgs(name, textValue2.ToLower());
        }
    }
}