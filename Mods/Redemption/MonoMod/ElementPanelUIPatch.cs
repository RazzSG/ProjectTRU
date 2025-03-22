using System.Reflection;
using CalamityRuTranslate.Common;
using CalamityRuTranslate.Common.Utilities;
using CalamityRuTranslate.Core.Config;
using CalamityRuTranslate.Core.MonoMod;
using MonoMod.Cil;
using Redemption.UI;

namespace CalamityRuTranslate.Mods.Redemption.MonoMod;

public class ElementPanelUIPatch : ILPatcher
{
    public override bool AutoLoad => ModInstances.Redemption != null && TRuConfig.Instance.RedemptionLocalization && TranslationHelper.IsRussianLanguage;
    
    public override MethodInfo ModifiedMethod => typeof(ElementPanelUI).GetCachedMethod(nameof(ElementPanelUI.Draw));

    public override ILContext.Manipulator PatchMethod { get; } = il =>
    {
        TranslationHelper.ModifyIL(il, 465, 491);
        TranslationHelper.ModifyIL(il, 90f, 135f);
        TranslationHelper.ModifyIL(il, 90f, 135f, 2);
        TranslationHelper.ModifyIL(il, "\n -", "\n ");
        TranslationHelper.ModifyIL(il, "\n -", "\n ", 2);
        TranslationHelper.ModifyIL(il, 2, 3, 4);
    };
}