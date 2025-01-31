using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using FargowiltasSouls.Content.UI;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.FargowiltasSouls.MonoMod;

public class DifficultySelectionMenuPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.FargowiltasSouls != null && TRuConfig.Instance.FargowiltasSoulsLocalization && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(DifficultySelectionMenu).GetCachedMethod(nameof(DifficultySelectionMenu.UpdateElements));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, -60f, -90f);
    };
}