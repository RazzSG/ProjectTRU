using System.Reflection;
using CalamityMod.UI.CalamitasEnchants;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class CalamitasEnchantUIDrawEnchantmentCost : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(CalamitasEnchantUI).GetCachedMethod(nameof(CalamitasEnchantUI.DrawEnchantmentCost));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Cost: ", "Стоимость: ");
        TranslationHelper.ModifyIL(il, "Exhume", "Наполнение");
    };
}

public class CalamitasEnchantUIInteractWithEnchantIcon : ILPatcher
{
    public override bool AutoLoad => ModsCall.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(CalamitasEnchantUI).GetCachedMethod(nameof(CalamitasEnchantUI.InteractWithEnchantIcon));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Exhume", "Наполнение");
        TranslationHelper.ModifyIL(il, "Exhume", "Наполнение", 2);
        TranslationHelper.ModifyIL(il, "Exhume", "Наполнение", 3);
    };
}