using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class MasterLibramGaugePatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Thorium != null && TRuConfig.Instance.ThoriumModLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.Thorium.Code.GetCachedType("ThoriumMod.UI.ResourceBars.MasterLibramGauge").GetCachedMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Water", "Вода");
        TranslationHelper.ModifyIL(il, "Cursed Flame", "Проклятый огонь");
        TranslationHelper.ModifyIL(il, "Ichor", "Ихор");
        TranslationHelper.ModifyIL(il, "Crystal", "Кристалл");
        TranslationHelper.ModifyIL(il, "Shadow", "Тень");
        TranslationHelper.ModifyIL(il, "Death", "Смерть");
        TranslationHelper.ModifyIL(il, "N/A", "Н/Д");
    };
}