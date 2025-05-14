using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.StarsAbove.MonoMod;

public class CelestialCompassPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.StarsAbove.Code.GetType("StarsAbove.UI.CelestialCartography.CelestialCompass").FindMethod("Update");
    
    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 524f, 564f);
        TranslationHelper.ModifyIL(il, 546f, 586f);
        TranslationHelper.ModifyIL(il, 568f, 608f);
    };
}