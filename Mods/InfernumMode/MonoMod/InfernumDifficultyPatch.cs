using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using InfernumMode.Content.UI;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.InfernumMode.MonoMod;

public class InfernumDifficultyFavoredDifficultyAtTier : ILPatcher
{
    public override bool AutoLoad => ModInstances.Infernum != null && TRuConfig.Instance.InfernumModeLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(InfernumDifficulty).GetCachedMethod(nameof(InfernumDifficulty.FavoredDifficultyAtTier));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "Death", "Смерть");
    };
}