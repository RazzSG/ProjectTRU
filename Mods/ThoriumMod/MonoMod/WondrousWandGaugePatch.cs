using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class WondrousWandGaugePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Thorium != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModsCall.Thorium.Code.GetCachedType("ThoriumMod.UI.ResourceBars.WondrousWandGauge").GetCachedMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Fire", "Огонь");
        TranslationHelper.ModifyIL(il, "Ice", "Лёд");
        TranslationHelper.ModifyIL(il, "Shadow", "Тень");
        TranslationHelper.ModifyIL(il, "Ichor", "Ихор");
        TranslationHelper.ModifyIL(il, "Cursed Flame", "Проклятый огонь");
        TranslationHelper.ModifyIL(il, "N/A", "Н/Д");
    };
}