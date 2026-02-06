using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Terraria;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class FurnitureCommonPatch : OnPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
     
    public override MethodInfo ModifiedMethod => ModInstances.Calamity.Code.GetType("CalamityMod.Tiles.FurnitureCommon").FindMethod("ClockRightClick");

    public override Delegate Delegate => Translate;

    private bool Translate(Func<bool> _)
    {
        double time = Main.time;
        
        if (!Main.dayTime)
            time += 54000.0;
        
        time = time / 86400.0 * 24.0;
        time = (time - 7.5 - 12.0 + 24.0) % 24.0;

        int intTime = (int)time;
        double minutes = (int)((time - intTime) * 60.0);
        string text = minutes.ToString("00");
        
        Main.NewText($"Время: {intTime}:{text}", 255, 240, 20);
        return true;
    }
}