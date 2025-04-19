using System.Reflection;
using CalamityMod.UI.DraedonLogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class DraedonsLogGUIPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TRuConfig.Instance.CalamityModLocalization && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(DraedonsLogGUI).FindMethod(nameof(DraedonsLogGUI.Draw));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        // Максимальная длина текста
        TranslationHelper.ModifyIL(il, 40, -50);
    };
}