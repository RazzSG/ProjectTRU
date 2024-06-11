using System;
using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using Fargowiltas.UI;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.Fargowiltas.MonoMod;

public class StatButtonUIRebuildStatList : OnPatcher
{
    public override bool AutoLoad => ModInstances.Fargowiltas != null && TRuConfig.Instance.FargowiltasLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(StatSheetUI).GetCachedMethod(nameof(StatSheetUI.AddStat), new []{typeof(string), typeof(int)});
    
    private delegate void AddStatDelegate(StatSheetUI self, string text, int item = -1);

    public override Delegate Delegate => Translation;
    
    private void Translation(AddStatDelegate orig, StatSheetUI self, string text, int item = -1)
    {
        text = text
            .Replace("Rogue Damage:", "Разбойный урон:")
            .Replace("Rogue Critical:", "Разбойный шанс крит. удара:");
        
        orig.Invoke(self, text, item);
    }
}

public class StatButtonAddStat : ILPatcher
{
    public override bool AutoLoad => ModInstances.Fargowiltas != null && TRuConfig.Instance.FargowiltasLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(StatSheetUI).GetCachedMethod(nameof(StatSheetUI.AddStat), new []{typeof(string), typeof(int)});

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        //Сдвигаем второй столбец характеристик вправо
        TranslationHelper.ModifyIL(il, 8, -102, 2);
    };
}