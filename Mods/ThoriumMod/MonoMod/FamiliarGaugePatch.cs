using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class FamiliarGaugePatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Thorium != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.Thorium.Code.GetCachedType("ThoriumMod.UI.ResourceBars.FamiliarGauge").GetCachedMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Return", "Возврат");
        TranslationHelper.ModifyIL(il, "Rally", "Сбор");
        TranslationHelper.ModifyIL(il, "Target", "Цель");
        TranslationHelper.ModifyIL(il, "Attack", "Атака");
        TranslationHelper.ModifyIL(il, "Ability", "Способность");
        TranslationHelper.ModifyIL(il, "N/A", "Н/Д");
    };
}