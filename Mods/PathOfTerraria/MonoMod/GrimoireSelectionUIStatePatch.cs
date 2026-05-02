using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.PathOfTerraria.MonoMod;

public class BuildStoragePatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.PathOfTerraria.Code.GetType("PathOfTerraria.Common.UI.GrimoireSelection.GrimoireSelectionUIState").FindMethod("BuildStorage");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 1f, 0.9f);
        TranslationHelper.ModifyIL(il, 0.5f, 0.53f);
    };
}

public class DrawHelpTextPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.PathOfTerraria.Code.GetType("PathOfTerraria.Common.UI.GrimoireSelection.GrimoireSelectionUIState").FindMethod("DrawHelpText");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 1f, 0.8f);
    };
}

public class DrawMorganaHelpPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => ModInstances.PathOfTerraria.Code.GetType("PathOfTerraria.Common.UI.GrimoireSelection.GrimoireSelectionUIState").FindMethod("DrawMorganaHelp");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 1.5f, 1.44f);
        TranslationHelper.ModifyIL(il, 250f, 220f);
        TranslationHelper.ModifyIL(il, 544f, 564f);
    };
}