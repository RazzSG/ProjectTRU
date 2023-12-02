using System.Reflection;
using CalamityMod.UI.DraedonSummoning;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;

namespace CalamityRuTranslate.Mods.CalamityMod.MonoMod;

public class CodebreakerUIInquiryText : ILPatcher
{
    public override bool AutoLoad => ModInstances.Calamity != null && TranslationHelper.IsRussianLanguage;

    public override MethodInfo ModifiedMethod => typeof(CodebreakerUI).GetCachedMethod("get_InquiryText");

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, "State your inquiry.", "Изложите свой запрос.");
    };
}