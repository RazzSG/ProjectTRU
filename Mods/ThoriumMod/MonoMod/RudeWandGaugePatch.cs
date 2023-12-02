using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class RudeWandGaugePatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Thorium != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.Thorium.Code.GetCachedType("ThoriumMod.UI.ResourceBars.RudeWandGauge").GetCachedMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Pulse", "Импульс");
        TranslationHelper.ModifyIL(il, "Laser", "Лазер");
        TranslationHelper.ModifyIL(il, "Buster", "Уничтожение");
        TranslationHelper.ModifyIL(il, "Spread", "Рассеивание");
        TranslationHelper.ModifyIL(il, "N/A", "Н/Д");
    };
}