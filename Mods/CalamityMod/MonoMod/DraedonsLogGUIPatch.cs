using System.Reflection;
using CalamityMod.UI.DraedonLogs;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class DraedonsLogGUIPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;
        
    public override MethodInfo ModifiedMethod => typeof(DraedonsLogGUI).GetCachedMethod(nameof(DraedonsLogGUI.Draw));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        // Положение текста в журналах Дрэйдона
        TranslationHelper.ModifyIL(il, 40, -40);
        TranslationHelper.ModifyIL(il, 350f, 330f);
    };
}