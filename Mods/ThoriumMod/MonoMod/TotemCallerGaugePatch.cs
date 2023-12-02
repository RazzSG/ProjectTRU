using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class TotemCallerGaugePatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Thorium != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.Thorium.Code.GetCachedType("ThoriumMod.UI.ResourceBars.TotemCallerGauge").GetCachedMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Fire", "Огонь");
        TranslationHelper.ModifyIL(il, "Earth", "Земля");
        TranslationHelper.ModifyIL(il, "Wind", "Ветер");
        TranslationHelper.ModifyIL(il, "Water", "Вода");
        TranslationHelper.ModifyIL(il, "N/A", "Н/Д");
    };
}