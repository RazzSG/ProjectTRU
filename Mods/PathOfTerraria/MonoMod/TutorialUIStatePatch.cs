using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.PathOfTerraria.MonoMod;

public class TutorialUIStatePatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.PathOfTerraria.Code.GetType("PathOfTerraria.Common.UI.Guide.TutorialUIState").FindMethod("DrawBacked");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 40f, 50f);
        TranslationHelper.ModifyIL(il, 24f, 18f);
    };
}