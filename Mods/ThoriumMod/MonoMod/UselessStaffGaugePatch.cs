using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.ThoriumMod.MonoMod;

public class UselessStaffGaugePatch : ILPatcher
{
    public override bool AutoLoad => ModsCall.Thorium != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModsCall.Thorium.Code.GetCachedType("ThoriumMod.UI.ResourceBars.UselessStaffGauge").GetCachedMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Exorcise", "Изгнание");
        TranslationHelper.ModifyIL(il, "Reflect", "Отражение");
        TranslationHelper.ModifyIL(il, "Drown", "Утопление");
        TranslationHelper.ModifyIL(il, "N/A", "Н/Д");
    };
}