using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class GeomancersBrushGaugePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Thorium != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModsCall.Thorium.Code.GetCachedType("ThoriumMod.UI.ResourceBars.GeomancersBrushGauge").GetCachedMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Fire", "Огонь");
        TranslationHelper.ModifyIL(il, "Earth", "Земля");
        TranslationHelper.ModifyIL(il, "Wind", "Ветер");
        TranslationHelper.ModifyIL(il, "N/A", "Н/Д");
    };
}