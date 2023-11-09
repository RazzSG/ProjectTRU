using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using Terraria;
using ThoriumMod.Tiles;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class FurnitureClockPatch : OnPatcher
{
    public override bool AutoLoad => ModsCall.Thorium != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(FurnitureClock).GetCachedMethod(nameof(FurnitureClock.RightClick));

    private delegate bool RightClickDelegate(FurnitureClock self, int x, int y);

    public override Delegate Delegate => Translation;
    
    private bool Translation(RightClickDelegate orig, FurnitureClock self, int x, int y)
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