using System.Reflection;
using CalamityMod.UI.DraedonSummoning;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class HandleDecryptionStuffPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(CodebreakerUI).FindMethod(nameof(CodebreakerUI.HandleDecryptionStuff));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        // Максимальная длина текста
        TranslationHelper.ModifyIL(il, 1.5, 1.60);
    };
}

public class DisplayTextSelectionOptionsPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(CodebreakerUI).FindMethod(nameof(CodebreakerUI.DisplayTextSelectionOptions));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 0.85f, 0.7f);
    };
}