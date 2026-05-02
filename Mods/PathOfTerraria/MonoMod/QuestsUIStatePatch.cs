using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using PathOfTerraria.Common.UI.Quests;

namespace CalamityRuTranslate.Mods.PathOfTerraria.MonoMod;

public class QuestsUIStatePatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.PathOfTerraria != null && TRuConfig.Instance.PathOfTerrariaLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(QuestsUIState).FindMethod(nameof(QuestsUIState.Toggle));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 0.55f, 0.55f);
        TranslationHelper.ModifyIL(il, 0.45f, 0.75f);
    };
}