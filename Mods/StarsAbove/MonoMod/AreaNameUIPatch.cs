using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.StarsAbove.MonoMod;

public class AreaNameUIPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.StarsAbove != null && TRuConfig.Instance.StarsAboveLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.StarsAbove.Code.GetType("StarsAbove.UI.CelestialCartography.AreaNameUI").GetCachedMethod("DrawSelf");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "StarsAbove/UI/CelestialCartography/LocationNames/", "CalamityRuTranslate/Assets/Sprites/StarsAbove/");
        TranslationHelper.ModifyIL(il, "StarsAbove/UI/CelestialCartography/LocationNames/", "CalamityRuTranslate/Assets/Sprites/StarsAbove/", 2);
    };
}